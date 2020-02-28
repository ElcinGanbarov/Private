using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa bu xananı doldurun"),StringLength(255,ErrorMessage ="Hərflərin sayı 255-dən çox olmamalıdır")]
        public string TitleUp { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string TitleDown { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(500, ErrorMessage = "Hərflərin sayı 500-dən çox olmamalıdır")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(400, ErrorMessage = "Hərflərin sayı 400-dən çox olmamalıdır")]
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile UpdatePhoto { get; set; }
    }
}
