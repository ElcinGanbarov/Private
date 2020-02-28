using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AboutController : Controller
    {
        private AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            AboutModel aboutModel = new AboutModel
            {
                Abouts=_context.Abouts,
                TeamEmployees=_context.TeamEmployees
            };
            return View(aboutModel);
        }

    }
}