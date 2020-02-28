using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.FinalArea.Controllers
{
    [Area("FinalArea")]
    [Authorize(Roles = Utility.AdminRole)]
    public class BrandController : Controller
    {
        private AppDbContext _context;
        public BrandController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Brand
        public IActionResult Index()
        {
            var brand = _context.Brands;
            return View(brand);

        }

        // GET: Brand/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Brand brand =await _context.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            return View(brand);
        }

        // GET: Brand/Create
        public IActionResult Create()
        {
            return View();
          
        }

        // POST: Brand/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        // GET: Brand/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            Brand brand =await _context.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            return View(brand);
        }

        // POST: Brand/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Brand brand)
        {
            if (id == null) return NotFound();
            Brand brandDb =await _context.Brands.FindAsync(id);
            if (brandDb == null) return RedirectToAction(nameof(Index));

            if (!ModelState.IsValid)
            {
                return View(brandDb);
            }

            brandDb.Name = brand.Name;
            brandDb.Details = brand.Details;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Brand/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Brand brand =await _context.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            return View(brand);
        }

        // POST: Brand/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBrand(int? id)
        {
            Brand brand = await _context.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            _context.Brands.Remove(brand);
             await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}