using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspWebSiteH.Data;
using AspWebSiteH.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspWebSiteH.Controllers
{
    public class ProductController : Controller
    {
        private readonly WebSiteConnection _context;
        public ProductController(WebSiteConnection context)
        {
            _context = context;
        }
        // GET: Product
        public ActionResult Index()
        {
            var product = _context.Product.Include("Category").ToList();

            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            FillViewBags();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
          
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                 _context.Product.Add(product);
                 _context.SaveChanges();
                  return RedirectToAction(nameof(Index));
                }

                     FillViewBags();
                     return View(product);  
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = _context.Product.Include("Category").FirstOrDefault(p=>p.Id==id);
            FillViewBags();
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Product product)
        {
            //if (ModelState.IsValid)
            //{  
            //    _context.Entry(product).State = EntityState.Modified;
            //    _context.SaveChanges();
            //    return RedirectToAction(nameof(Index));
            //}
            //FillViewBags();
            //return View(product);
            //return Ok(product.Price);
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (product == null) return NotFound();
            Product productDb = _context.Product.Include("Category").FirstOrDefault(p=>p.Id==id);
            productDb.Title = product.Title;
            productDb.Price = Convert.ToDecimal(product.Price);
            productDb.CategoryId = product.CategoryId;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
           Product product=_context.Product.Find(id);
            if (product == null) return NotFound();
            _context.Product.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private void FillViewBags()
        {
            var category = _context.Category.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });
            ViewBag.Category = category;
        }
    }
}