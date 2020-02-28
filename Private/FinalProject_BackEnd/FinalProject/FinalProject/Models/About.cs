using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa bu xananı doldurun"),StringLength(500,ErrorMessage ="Simbolların sayı 500-dən çox ola bilməz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(300, ErrorMessage = "Simbolların sayı 500-dən çox ola bilməz")]
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile UpdatePhoto { get; set; }
    }
}
