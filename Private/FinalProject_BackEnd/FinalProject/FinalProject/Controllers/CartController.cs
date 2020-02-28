using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.Utilities;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace FinalProject.Controllers
{
    public class CartController : Controller
    {
        private AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Add(int? id)
        {
            

            Product product = await _context.Products.Include(x => x.ProductImages).FirstOrDefaultAsync(p => p.Id == id);
            BasketProduct basketProduct = product;
            
           

           string cart=HttpContext.Session.GetString("cart");

            List<BasketProduct> products = new List<BasketProduct>();

            if (cart != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketProduct>>(cart);
            }
           

            var selected = products.FirstOrDefault(p => p.Id == id);

            if (selected == null)
            {
                products.Add(basketProduct);

            }
            else
            {
                selected.Quantity += 1;

            }

            string productsJSON = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("cart", productsJSON);

            return RedirectToAction("Index", "ProductDetail");
        }

        public IActionResult Remove(int? id)
        {
            

            string cart = HttpContext.Session.GetString("cart");

            List<Product> products = new List<Product>();

            if (cart != null)
            {
                products = JsonConvert.DeserializeObject<List<Product>>(cart);
            }

            Product product = products.FirstOrDefault(p => p.Id == id);
            products.Remove(product);


            string productsJSON = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("cart", productsJSON);

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Index()
        {
            string cart = HttpContext.Session.GetString("cart");
            List<BasketProduct> basketProducts = new List<BasketProduct>();

            if (cart != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketProduct>>(cart);
            }

            return View(basketProducts);
        }




    }
}