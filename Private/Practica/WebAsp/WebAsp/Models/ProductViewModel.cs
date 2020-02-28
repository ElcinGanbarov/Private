using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAsp.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
    }
}
