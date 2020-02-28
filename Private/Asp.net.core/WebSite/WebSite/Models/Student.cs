using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Student
    {
        public int Id { get; set; }
        //[Display(Name ="Telebe adi")]
        [Required(ErrorMessage ="Ad Mecburudir")]
        [MaxLength(50, ErrorMessage = "Max 50 xarakter olur")]
        [MinLength(3,ErrorMessage ="Min 3 xarakter ola biler")]
        //[DataType(DataType.Password)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Mecburudir")]
        [MaxLength(50,ErrorMessage ="Max 50 xarakter olur")]
        [MinLength(3, ErrorMessage = "Min 3 xarakter ola biler")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Group adi Mecburudir")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
