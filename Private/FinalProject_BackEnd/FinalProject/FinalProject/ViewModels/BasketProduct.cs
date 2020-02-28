using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public decimal? Price { get; set; }
        public byte? Discount { get; set; }
        public int? Quantity { get; set; }
        public decimal? Subtotal { get; set; }
        public string Image { get; set; }
        public int CountView { get; set; }
    }
}
