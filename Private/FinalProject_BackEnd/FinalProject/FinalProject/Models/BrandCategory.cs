using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class BrandCategory
    {
        public int Id { get; set; }
        public int CategorieId { get; set; }
        public int BrandId { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual Brand Brand { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
