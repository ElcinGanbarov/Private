using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewComponents
{

    public class HeaderViewComponent:ViewComponent
    {
        private AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                Image = (await _context.BioHeaders.FirstAsync()).Image,
                Products = _context.Products,

                Categories = await _context.Categories.Include(m => m.BrandCategories).Select(m => new CategoryViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Brands = m.BrandCategories.Select(n => new SubCategoryViewModel
                    {
                        Id = n.BrandId,
                        Name = n.Brand.Name
                    })
                }).ToListAsync()
            };

            return View(headerModel);
        }
    }
}
