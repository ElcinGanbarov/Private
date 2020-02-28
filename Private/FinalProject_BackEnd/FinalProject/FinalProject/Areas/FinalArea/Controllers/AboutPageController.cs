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

namespace FinalProject.Controllers
{
    [Area("FinalArea")]
    [Authorize(Roles = Utility.AdminRole)]
    public class AboutPageController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;
        public AboutPageController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: AboutPage
        public IActionResult Index()
        {
            return View(_context.Abouts);
        }

        // GET: AboutPage/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }


        // GET: AboutPage/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, About about)
        {
            if (id == null) return NotFound();

            About dbAbout = await _context.Abouts.FindAsync(id);
            if (dbAbout == null) return RedirectToAction(nameof(Index));

            if ( ModelState["Description"].ValidationState == ModelValidationState.Invalid)
            {
                return View(dbAbout);
            }

            if (about.UpdatePhoto != null)
            {
                if (!about.UpdatePhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Bu fayl şəkil formatında deyil");
                    return View();
                }
                if (!about.UpdatePhoto.CheckImageSize(1))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1 MB-dan çox ola bilməz");
                    return View();

                }
                string filename = await about.UpdatePhoto.CopyImage(_env.WebRootPath, "about");
                Utility.DeleteImageFromFolder(_env.WebRootPath, dbAbout.Image);

                dbAbout.Image = filename;
            }
            dbAbout.Description = about.Description;
         

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




    }
}
