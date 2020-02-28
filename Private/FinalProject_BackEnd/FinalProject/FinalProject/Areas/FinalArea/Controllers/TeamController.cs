using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Extentions;
using FinalProject.Models;
using FinalProject.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FinalProject.Areas.FinalArea.Controllers
{
    [Area("FinalArea")]
    [Authorize(Roles = Utility.AdminRole)]
    public class TeamController : Controller
    {

        private AppDbContext _context;
        private IHostingEnvironment _env;

        public TeamController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: MainSlider
        public IActionResult Index()
        {
            return View(_context.TeamEmployees);
        }

        // GET: MainSlider/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            TeamEmployee employee = await _context.TeamEmployees.FindAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        // GET: MainSlider/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MainSlider/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamEmployee employee)
        {

            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Surname"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Description"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Position"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Photo"].ValidationState == ModelValidationState.Invalid )
            {
                return View();
            }


            if (!employee.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Bu şəkil formatında deyil");
                return View();
            }

            if (!employee.Photo.CheckImageSize(1))
            {
                ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1Mb-dan çox olmamalıdır");
                return View();
            }

            string filename = await employee.Photo.CopyImage(_env.WebRootPath, "team");

            employee.Image = filename;
            await _context.TeamEmployees.AddAsync(employee);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }

        // GET: MainSlider/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            TeamEmployee employee = await _context.TeamEmployees.FindAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TeamEmployee employee)
        {
            if (id == null) return NotFound();

            TeamEmployee dbEmployee = await _context.TeamEmployees.FindAsync(id);
            if (dbEmployee == null) return RedirectToAction(nameof(Index));

            if (ModelState.IsValid)
            {
                return View(dbEmployee);
            }

            if (employee.UpdatePhoto != null)
            {
                if (!employee.UpdatePhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Bu fayl şəkil formatında deyil");
                    return View();
                }
                if (!employee.UpdatePhoto.CheckImageSize(1))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1 MB-dan çox ola bilməz");
                    return View();

                }
                string filename = await employee.UpdatePhoto.CopyImage(_env.WebRootPath, "team");
                Utility.DeleteImageFromFolder(_env.WebRootPath, dbEmployee.Image);

                dbEmployee.Image = filename;
            }
            dbEmployee.Description = employee.Description;
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.Position = employee.Position;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            TeamEmployee teamEmployee = await _context.TeamEmployees.FindAsync(id);
            if (teamEmployee == null) return NotFound();
            return View(teamEmployee);
        }

        // POST: MainSlider/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            TeamEmployee teamEmployee = await _context.TeamEmployees.FindAsync(id);
            Utility.DeleteImageFromFolder(_env.WebRootPath, teamEmployee.Image);
            _context.TeamEmployees.Remove(teamEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}