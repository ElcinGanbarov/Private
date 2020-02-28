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

namespace FinalProject.Areas.FinalArea.Controllers
{
    [Area("FinalArea")]
    [Authorize(Roles = Utility.AdminRole)]
    public class CategoryController : Controller
    {
        private AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Category
        public IActionResult Index()
        {
            var category = _context.Categories;
            return View(category);
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Categorie categorie =await _context.Categories.FindAsync(id);
            if (categorie == null) return NotFound();
            return View(categorie);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categorie categorie)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.Categories.AddAsync(categorie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Categorie categorie =await _context.Categories.FindAsync(id);
            if (categorie == null) return NotFound();
            return View(categorie);
            
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Categorie categorie)
        {
            if (id == null) return NotFound();
            Categorie categoryDb =await _context.Categories.FindAsync(id);
            if (categoryDb == null) return NotFound();

            if (!ModelState.IsValid)
            {
                return View();
            }

            categoryDb.Name = categoryDb.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Categorie categorie =await _context.Categories.FindAsync(id);
            if (categorie == null) return NotFound();
            return View(categorie);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Categorie categorie = await _context.Categories.FindAsync(id);
            if (categorie == null) return NotFound();
            _context.Categories.Remove(categorie);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}