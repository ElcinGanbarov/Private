using FinalProject.Models;
using FinalProject.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class DetailModel
    {
        public IEnumerable<HomeSlider> HomeSliders { get; set; }
        public IEnumerable<Categorie> Categories { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<Product> LikeProducts { get; set; }
        public Product Product { get; set; }
        public Categorie Categorie { get; set; }
        public ProductImage ProductImage { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<BrandCategory> BrandCategories { get; set; }
        
     

    }
}
