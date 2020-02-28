using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.AdminViewModels
{
    public class ProductModel
    {
        public Product Product { get; set; }
        public ProductImage ProductImage { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<BrandCategory> BrandCategories { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Categorie> Categories { get; set; }
    }
}
