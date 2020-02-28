using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun"), StringLength(255, ErrorMessage = "Hərflərin sayı 255-dən çox olmamalıdır")]
        public string Name { get; set; }
        public string ActiveField { get; set; }
        public ICollection<BrandCategory> BrandCategories { get; set; }

    }
}
