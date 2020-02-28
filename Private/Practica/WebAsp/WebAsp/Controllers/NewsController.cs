using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAsp.Controllers
{   [Route("news")]
    public class NewsController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            return Content("TEst");
        }
        [Route("home/{slug:maxlength(80)}")]
        public IActionResult Read(string slug)
        {
            return Content(slug);
        }
        [Route("aboutus")]
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}