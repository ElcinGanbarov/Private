using FinalProject.Models.Comments;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class AppUser:IdentityUser
    {
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string Surname { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
      


    }
}
