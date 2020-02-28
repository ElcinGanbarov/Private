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
    public class BrandCaruselController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;

        public BrandCaruselController(AppDbContext context,IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: BrandCarusel
        public IActionResult Index()
        {
            return View(_context.BrandCarusels);
        }

        // GET: BrandCarusel/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            BrandCarusel carusel = await _context.BrandCarusels.FindAsync(id);
            if (carusel == null) return NotFound();
            return View(carusel);
        }

        // GET: BrandCarusel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BrandCarusel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandCarusel carusel)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }


            if (!carusel.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Bu şəkil formatında deyil");
                return View();
            }

            if (!carusel.Photo.CheckImageSize(1))
            {
                ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1Mb-dan çox olmamalıdır");
                return View();
            }

            string filename = await carusel.Photo.CopyImage(_env.WebRootPath, "brand");

            carusel.Image = filename;
            await _context.BrandCarusels.AddAsync(carusel);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: BrandCarusel/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            BrandCarusel brandCarusel = await _context.BrandCarusels.FindAsync(id);
            if (brandCarusel == null) return NotFound();
            return View(brandCarusel);
        }

        // POST: BrandCarusel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BrandCarusel carusel)
        {
            if (id == null) return NotFound();
            BrandCarusel brandCarusel =await _context.BrandCarusels.FindAsync(id);
            if (brandCarusel == null) return RedirectToAction(nameof(Index));

            if (carusel.UpdatePhoto != null)
            {
                if (!carusel.UpdatePhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Bu fayl şəkil formatında deyil");
                    return View();
                }
                if (!carusel.UpdatePhoto.CheckImageSize(1))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1 MB-dan çox ola bilməz");
                    return View();

                }
                string filename = await carusel.UpdatePhoto.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImageFromFolder(_env.WebRootPath, brandCarusel.Image);

                brandCarusel.Image = filename;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            BrandCarusel brandCarusel = await _context.BrandCarusels.FindAsync(id);
            if (brandCarusel == null) return NotFound();
            return View(brandCarusel);
        }

        // POST: MainSlider/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {

            BrandCarusel brand = await _context.BrandCarusels.FindAsync(id);
            Utility.DeleteImageFromFolder(_env.WebRootPath, brand.Image);
            _context.BrandCarusels.Remove(brand);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}