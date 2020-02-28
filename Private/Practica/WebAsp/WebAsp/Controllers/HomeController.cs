using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAsp.Models;

namespace WebAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Id = 12,
                    Name = "Samsung QE75Q900RBUXRU",
                    Price = 18999,
                    DiscountPrice = 13999
                },
                   new ProductViewModel
                {
                    Id = 89,
                    Name = "Xbox One Phantom White",
                    Price = 129.9M,
                    DiscountPrice = null
                },

                new ProductViewModel
                {
                    Id = 911,
                    Name = "Delonghi SW12A.BK",
                    Price = 99.9M,
                    DiscountPrice = 89M
                },
                  new ProductViewModel
                {
                    Id = 911,
                    Name = "Delonghi SW12A.BK",
                    Price = 99.9M,
                    DiscountPrice = 89M
                },
                    new ProductViewModel
                {
                    Id = 911,
                    Name = "Delonghi SW12A.BK",
                    Price = 99.9M,
                    DiscountPrice = 89M
                },
                      new ProductViewModel
                {
                    Id = 911,
                    Name = "Delonghi SW12A.BK",
                    Price = 99.9M,
                    DiscountPrice = 89M
                }

            };
            return View(data);
        }

        public IActionResult Privacy()
        {
            var model = new List<PartnerViewModel>
            {
                new PartnerViewModel
                {
                    Url = "https://maxi.az",
                    Photo = "https://maxi.az/local/templates/main/images/logo.png"
                },

                new PartnerViewModel
                {
                    Url = "https://www.bakuelectronics.az/",
                    Photo = "https://www.bakuelectronics.az/assets/img/logo.svg"
                },

                new PartnerViewModel
                {
                    Url = "https://kontakt.az/",
                    Photo = "https://kontakt.az/wp-content/uploads/2016/08/logoyeni-1.png"
                },

                new PartnerViewModel
                {
                    Url= "https://www.irtelecom.az",
                    Photo = "https://www.irtelecom.az/site/templates/img/logo.svg"
                }
            };
            return View(model);
      
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
