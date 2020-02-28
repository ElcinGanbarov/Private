using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var productsOfCategories = new Dictionary<Categorie, IEnumerable<Product>>();

            foreach (var categorie in _context.Categories)
            {
                var products = _context.Products
                            .Include(x => x.BrandCategory)
                            .Include(y => y.BrandCategory.Brand)
                            .Include(m => m.ProductImages)
                            .Include(c => c.BrandCategory.Categorie)
                            .Where(x => x.BrandCategory.CategorieId == categorie.Id)
                            .Take(9);
                productsOfCategories.Add(categorie, products);
            }

            HomeModel homeModel = new HomeModel
            {
                HomeSliders = _context.HomeSliders,
                ProductImages = _context.ProductImages.Where(i => i.ProductId == i.Product.Id).ToList(),
                Products = _context.Products
                            .Include(x => x.BrandCategory)
                            .Include(y => y.BrandCategory.Brand)
                            .Include(m => m.ProductImages)
                            .Include(c => c.BrandCategory.Categorie)
                            .ToList(),
                Categories = _context.Categories,
                BrandCarusels = _context.BrandCarusels,
                ProductsOfCategories = productsOfCategories

            };
            return View(homeModel);
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult SearchProduct(string str)
        {
            HeaderViewModel headerViewModel = new HeaderViewModel
            {
                Products = _context.Products.Where(p => p.Name.Contains(str)).Take(5)
            };

            return PartialView("_SearchView",headerViewModel);

        }

    }
}