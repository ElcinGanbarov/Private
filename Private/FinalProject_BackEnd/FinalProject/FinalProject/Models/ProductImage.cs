using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Active { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(400, ErrorMessage = "Hərflərin sayı 400-dən çox olmamalıdır")]
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public List<IFormFile> Photo { get; set; }
        [NotMapped]
        public List<IFormFile> UpdatePhoto { get; set; }

    }
}
