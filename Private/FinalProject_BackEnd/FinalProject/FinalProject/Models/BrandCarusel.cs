using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class BrandCarusel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(250, ErrorMessage = "Hərflərin sayı 250-dən çox olmamalıdır")]
        public string Image { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile UpdatePhoto { get; set; }
    }
}
