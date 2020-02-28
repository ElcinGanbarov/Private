using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.Models.Comments;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FinalProject.Controllers
{
  
    public class ProductDetailController : Controller
    {
       
        private AppDbContext _context;
        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }

      
        public IActionResult Index(int? producid,int? cateid)
        {

            if (producid != null)
            {
                var product = _context.Products.Where(p => p.Id == producid) 
                                               .Include(x => x.BrandCategory)
                                               .Include(y => y.BrandCategory.Brand)
                                               .Include(y => y.BrandCategory.Categorie)
                                               .Include(m => m.ProductImages)
                                               .FirstOrDefault(p=>p.Id==producid);
               

                DetailModel detailModel = new DetailModel
                {
                    ProductImages = product.ProductImages.ToList(),
                    Product = product,
                    LikeProducts = _context.Products.Where(m => m.BrandCategory.CategorieId == product.BrandCategory.CategorieId).ToList(),
                    Categories = _context.Categories.ToList(),
                    Brands = _context.Brands.ToList(),
                    BrandCategories = _context.BrandCategories.ToList(),

                };
                return View(detailModel);
            }
            var product2 = _context.Products.Include(p => p.BrandCategory)
                                            .Include(p => p.ProductImages)
                                            .Include(p => p.BrandCategory.Brand)
                                            .FirstOrDefault();
             
            DetailModel model = new DetailModel
            {
                ProductImages = product2.ProductImages.ToList(),
                Product = product2,
                LikeProducts = _context.Products.Where(m => m.BrandCategory.CategorieId == product2.BrandCategory.CategorieId).ToList(),
                Categories = _context.Categories.ToList(),
                Brands = _context.Brands.ToList(),
                BrandCategories = _context.BrandCategories.ToList(),
            };
            return View(model);

        }

    }
}