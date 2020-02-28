using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), EmailAddress(ErrorMessage ="Email ünvanını düzgün yazın"),DataType(DataType.EmailAddress),StringLength(300,ErrorMessage = "Simbolların sayı 255-dən çox olmamalıdır")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), Compare(nameof(Password)),DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
