using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Areas.AdminViewModels;
using FinalProject.DAL;
using FinalProject.Extentions;
using FinalProject.Models;
using FinalProject.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.FinalArea.Controllers
{
    [Area("FinalArea")]
    [Authorize(Roles = Utility.AdminRole)]
    public class ProductController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;
        public ProductController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: Product
        public IActionResult Index()
        {
            var product = _context.Products.Include(p => p.ProductImages).OrderByDescending(p=>p.CreateDate).ToList();
            ProductModel productModel = new ProductModel
            {
                Products = product,
                ProductImages=_context.ProductImages
            };
            return View(productModel);
           
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            var productDb = await _context.Products.Include(p => p.ProductImages)
                                         .Include(p => p.BrandCategory)
                                         .Include(p=>p.BrandCategory.Brand)
                                         .Include(p=>p.BrandCategory.Categorie)
                                         .FirstOrDefaultAsync(p => p.Id == id);
            if (productDb == null) return NotFound();

            ProductModel productModel = new ProductModel
            {
                Product = productDb,
                ProductImages = _context.ProductImages.Where(p => p.ProductId == id),
                BrandCategories = _context.BrandCategories,
                Categories = _context.Categories,
                Brands = _context.Brands

            };
            return View(productModel);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            var product = _context.Products.Include(x => x.ProductImages)
                                           .Include(p => p.BrandCategory.Categorie)
                                           .Include(m => m.BrandCategory.Brand).ToList();
            ProductModel productModel = new ProductModel
            {
                Products = product,
                ProductImages = _context.ProductImages.ToList(),
                Categories=_context.Categories,
                Brands=_context.Brands,
            };
            return View(productModel);

            
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product,ProductImage productImage,BrandCategory brandCategory)
        {
            
            if (ModelState.IsValid)
            {
                return View();
            }

            var id = 0;
            if(_context.BrandCategories.Any(x=>x.CategorieId==brandCategory.CategorieId && x.BrandId == brandCategory.BrandId))
            {
                id = _context.BrandCategories
                    .FirstOrDefault(x => x.CategorieId == brandCategory.CategorieId && x.BrandId == brandCategory.BrandId).Id;
            }
            else
            {
                var newBrandCategor = new BrandCategory
                {
                    CategorieId = brandCategory.CategorieId,
                    BrandId = brandCategory.BrandId,
                };
                await _context.BrandCategories.AddAsync(newBrandCategor);
                await _context.SaveChangesAsync();
                id = newBrandCategor.Id;
            }

        
            await _context.Products.AddAsync(new Product {
                Name = product.Name,
                BrandCategoryId = id,
                Price = product.Price,
                Count = product.Count,
                Discount = product.Discount,
                CreateDate = DateTime.Now,
                Details = product.Details,
                ViewsCount = 2
                
            });
            await _context.SaveChangesAsync();
            var productId = _context.Products.LastOrDefault();
            foreach (var item in productImage.Photo)
            {
                if (!item.IsImage())
                {
                    ModelState.AddModelError("Photo", "Bu şəkil formatında deyil");
                    return View();
                }

                if (!item.CheckImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan çox olmamalıdır");
                    return View();
                }
                string filename = await item.CopyImage(_env.WebRootPath, "products");
                productImage.ImageUrl = filename;
                await _context.ProductImages.AddAsync(new ProductImage
                {
                    ProductId = productId.Id,
                    ImageUrl = productImage.ImageUrl

                });
                await _context.SaveChangesAsync();
            }
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var productDb =await _context.Products.Include(p => p.ProductImages)
                                         .Include(p => p.BrandCategory)
                                         .Include(p => p.BrandCategory.Brand)
                                         .Include(p => p.BrandCategory.Categorie).FirstOrDefaultAsync(p=>p.Id==id);

            if (productDb == null) return NotFound();

            ProductModel productModel = new ProductModel
            {
                Product= productDb,
                ProductImages=_context.ProductImages.Where(p=>p.ProductId==id),
                BrandCategories=_context.BrandCategories,
                Categories=_context.Categories,
                Brands=_context.Brands

            };

            return View(productModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Product product, ProductImage productImage)
        {

            if (id == null) return NotFound();
            var productDb = await _context.Products.Include(p => p.ProductImages)
                                          .Include(p => p.BrandCategory)
                                          .FirstOrDefaultAsync(p => p.Id == id);
           

            if (productDb == null) return RedirectToAction(nameof(Index));

            if (ModelState.IsValid)
            {
                return View(productDb);
            }
            if (productImage.UpdatePhoto != null)
            {
                foreach (var item in productImage.UpdatePhoto)
                {

                    if (!item.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Bu şəkil formatında deyil");
                        return View();
                    }

                    if (item.CheckImageSize(2))
                    {
                        ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan çox olmamalıdır");
                        return View();
                    }

                    string filename = await item.CopyImage(_env.WebRootPath, "products");
                    Utility.DeleteImageFromFolder(_env.WebRootPath, productImage.ImageUrl);

                    productImage.ImageUrl = filename;

                }
            }

                productDb.Name = product.Name;
                productDb.Details = product.Details;
                productDb.Price = product.Price;
                productDb.Discount = product.Discount;
                productDb.CreateDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var productDb = await _context.Products.Include(p => p.ProductImages)
                                         .Include(p => p.BrandCategory)
                                         .FirstOrDefaultAsync(p => p.Id == id);
            if (productDb == null) return NotFound();

            ProductModel productModel = new ProductModel
            {
                Product = productDb,
                ProductImages = _context.ProductImages.Where(p => p.ProductId == id),
                BrandCategories = _context.BrandCategories,
                Categories = _context.Categories,
                Brands = _context.Brands

            };
            return View(productModel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null) return NotFound();
            Product product =await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            ProductImage productImage =await _context.ProductImages.FirstOrDefaultAsync(i => i.ProductId == id);
            if (productImage != null)
            {
                Utility.DeleteImageFromFolder(_env.WebRootPath, productImage.ImageUrl);
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}