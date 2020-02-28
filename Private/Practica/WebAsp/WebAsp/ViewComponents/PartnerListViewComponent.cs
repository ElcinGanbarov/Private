using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAsp.Models;

namespace WebAsp.ViewComponents
{
    public class PartnerListViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int colNo)
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
                ViewBag.colno = colNo;   
                return View(model);
        }
    }
}
