using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class BioHeader
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bu xananı doldurun")]
        public string Image { get; set; }
    }
}
