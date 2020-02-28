using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<HomeSlider> HomeSliders { get; set; }
        public IEnumerable<Categorie> Categories { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<BrandCategory> BrandCategories { get; set; }
        public IEnumerable<BrandCarusel> BrandCarusels { get; set; }
        public Dictionary<Categorie, IEnumerable<Product>> ProductsOfCategories { get;  set; }
    }

}
