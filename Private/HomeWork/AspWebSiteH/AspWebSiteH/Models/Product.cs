using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace AspWebSiteH.Models
{
    public class Product
    {
        public int Id { get; set; }
        [RegularExpression(@"([A-Z][^\s]*)")]
        [Required(ErrorMessage ="Mehsulun adi yazilmalidir.!")]
        [MaxLength(50,ErrorMessage ="Mehsulun adi maksimum 50 xarakter ola biler.!")]
        [MinLength(3,ErrorMessage ="Mehsulun adi minumum 3 xarakter ola biler.!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mehsulun qiymeti yazilmalidir.!")]
        //[Range(0.01, 100000.00,
        //ErrorMessage = "Qiymet  0.01 ve 100000.00 araliqinda olmalidir.!")]
        //  [Column(TypeName = "money")]
        //  [DataType(dataType: DataType.Currency)]
        //  [DisplayFormat(DataFormatString = "{0:M0}", ApplyFormatInEditMode = true)]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Mehsulun kateqoryasi mecburidir.!")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
