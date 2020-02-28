using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class TeamEmployee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Simbolların sayı 255-dən çox olmamalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Simbolların sayı 255-dən çox olmamalıdır")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(400, ErrorMessage = "Simbolların sayı 400-dən çox olmamalıdır")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(450, ErrorMessage = "Simbolların sayı 450-dən çox olmamalıdır")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(250, ErrorMessage = "Simbolların sayı 250-dən çox olmamalıdır")]
        public string Position { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile UpdatePhoto { get; set; }
    }
}
