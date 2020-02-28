using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{
    public class AboutUSController : Controller
    {
        public IActionResult Index()
        {
            List<string> names = new List<string>
            {
                "Elcin","Ilkin","Ceka","Meka"
            };
            return View(names);
        }
    }
}