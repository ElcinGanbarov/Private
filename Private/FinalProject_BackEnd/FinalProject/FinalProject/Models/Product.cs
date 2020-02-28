using FinalProject.Models.Comments;
using FinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(800, ErrorMessage = "Hərflərin sayı 800-dən çox olmamalıdır")]
        public string Details { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public decimal Price { get; set; }
        public byte Discount { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public int ViewsCount { get; set; }
        public int BrandCategoryId { get; set; }
        public string ActiveField { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual BrandCategory BrandCategory { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
   


        public static implicit operator BasketProduct(Product product)
        {
            return new BasketProduct
            {
                Id=product.Id,
                Name=product.Name,
                Details=product.Details,
                Price=product.Price,
                Discount=product.Discount,
                Image=product.ProductImages.FirstOrDefault()?.ImageUrl,
                Quantity=1
            };
        }


    }
}
