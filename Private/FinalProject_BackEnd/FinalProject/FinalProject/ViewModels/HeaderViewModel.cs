using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace FinalProject.ViewModels
{
    public class HeaderViewModel
    {

        public HeaderViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }

        public List<BasketProduct> BasketProducts{ get; set; }

        public string Image { get; set; }

        public List<CategoryViewModel> Categories = null;
        public IEnumerable<Product> Products { get; set; }
       
    }
}
