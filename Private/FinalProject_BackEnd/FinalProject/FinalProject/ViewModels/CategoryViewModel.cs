using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class CategoryViewModel
    {

        public CategoryViewModel()
        {
            Brands = new List<SubCategoryViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<SubCategoryViewModel> Brands { get; set; }

    }

    public class SubCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
