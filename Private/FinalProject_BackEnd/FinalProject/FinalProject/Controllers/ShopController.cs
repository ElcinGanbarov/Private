using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FinalProject.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? brandid, int? categoryid)
        {
                
                List<Models.Product> Products2 = _context.Products.Include(x => x.BrandCategory).Include(y => y.BrandCategory.Brand)
                .Include(m => m.ProductImages)
                .Where(x=>categoryid==null?true:x.BrandCategory.CategorieId==categoryid)
                .Where(x=>brandid==null?true:x.BrandCategory.BrandId==brandid)
                .OrderByDescending(m => m.Id).ToList();

                HomeModel homeModel2 = new HomeModel
                {
                    Products = Products2,
                    Categories = _context.Categories,
                    ProductImages = _context.ProductImages,
                    Brands = _context.Brands,
                    BrandCategories = _context.BrandCategories

                };
                return View(homeModel2);
        }

        public IActionResult Search(SearchModel search)
        {
            try
            {
                var categories = JsonConvert.DeserializeObject<List<int>>(search.Categories);
                var brand = JsonConvert.DeserializeObject<List<int>>(search.Brands);
                var products = _context.Products
                    .Include(x => x.BrandCategory)
                    .Include(x => x.BrandCategory.Brand)
                    .Include(x => x.BrandCategory.Categorie)
                    .Include(x => x.ProductImages)
                    .Where(x => categories.Count() == 0 ? true : categories.Contains(x.BrandCategory.CategorieId))
                    .Where(x => brand.Count() == 0 ? true : brand.Contains(x.BrandCategory.BrandId)).ToList();
                return PartialView("~/Views/Shared/_searchPartial.cshtml", products);
            }
            catch (Exception ex)
            {
                return PartialView(ex);
            }
        }


    }
}