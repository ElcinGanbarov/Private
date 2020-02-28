using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(100, ErrorMessage = "Simbolların sayı 100-dən çox ola bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(300, ErrorMessage = "Simbolların sayı 500-dən çox ola bilməz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(300, ErrorMessage = "Simbolların sayı 500-dən çox ola bilməz")]
        public string BackImage { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(100, ErrorMessage = "Simbolların sayı 100-dən çox ola bilməz")]
        public string HomePhone { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(100, ErrorMessage = "Simbolların sayı 100-dən çox ola bilməz")]
        public string MobilePhone { get; set; }
        [Required, EmailAddress(ErrorMessage = "Email ünvanını düzgün yazın"), DataType(DataType.EmailAddress), StringLength(300, ErrorMessage = "Simbolların sayı 300-dən çox ola bilməz")]
        public string Email { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile UpdatePhoto { get; set; }
    }
}
