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
    public class MainSliderController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;

        public MainSliderController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: MainSlider
        public IActionResult Index()
        {
            return View(_context.HomeSliders);
        }

        // GET: MainSlider/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _context.HomeSliders.FindAsync(id);
            if (homeSlider == null) return NotFound();
             return View(homeSlider);
        }

        // GET: MainSlider/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MainSlider/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeSlider slider)
        {
           
            if(ModelState["TitleUp"].ValidationState==ModelValidationState.Invalid ||
               ModelState["TitleDown"].ValidationState==ModelValidationState.Invalid ||
               ModelState["Description"].ValidationState==ModelValidationState.Invalid ||
               ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }


            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Bu şəkil formatında deyil");
                return View();
            }

            if (!slider.Photo.CheckImageSize(1))
            {
                ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1Mb-dan çox olmamalıdır");
                return View();
            }

            string filename = await slider.Photo.CopyImage(_env.WebRootPath, "slider");

            slider.Image = filename;
            await _context.HomeSliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }

        // GET: MainSlider/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider slider =await _context.HomeSliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, HomeSlider slider)
        {
            if (id == null) return NotFound();

            HomeSlider homeSlider =await _context.HomeSliders.FindAsync(id);
            if (homeSlider == null) return RedirectToAction(nameof(Index));

            if (ModelState["TitleUp"].ValidationState==ModelValidationState.Invalid ||
                ModelState["TitleUp"].ValidationState==ModelValidationState.Invalid ||
                ModelState["Description"].ValidationState == ModelValidationState.Invalid)
            {
                return View(homeSlider);
            }

            if (slider.UpdatePhoto != null)
            {
                if (!slider.UpdatePhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Bu fayl şəkil formatında deyil");
                    return View();
                }
                if (!slider.UpdatePhoto.CheckImageSize(1))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1 MB-dan çox ola bilməz");
                    return View();

                }
                string filename = await slider.UpdatePhoto.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImageFromFolder(_env.WebRootPath, homeSlider.Image);

                homeSlider.Image = filename;
            }
            homeSlider.TitleUp = slider.TitleUp;
            homeSlider.TitleDown = slider.TitleDown;
            homeSlider.Description = slider.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

      
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _context.HomeSliders.FindAsync(id);
            if (homeSlider == null) return NotFound();
            return View(homeSlider);
        }

        // POST: MainSlider/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            HomeSlider slider = await _context.HomeSliders.FindAsync(id);
            Utility.DeleteImageFromFolder(_env.WebRootPath, slider.Image);
            _context.HomeSliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}