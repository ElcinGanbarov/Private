using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspWebSiteH.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Mehsulun adi yazilmalidir.!")]
        [MaxLength(50, ErrorMessage = "Mehsulun adi maksimum 50 xarakter ola biler.!")]
        [MinLength(3, ErrorMessage = "Mehsulun adi minumum 3 xarakter ola biler.!")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
