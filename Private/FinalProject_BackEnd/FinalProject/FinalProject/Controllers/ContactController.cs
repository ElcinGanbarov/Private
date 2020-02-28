using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ContactController : Controller
    {
        private AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var contact = _context.Contacts.FirstOrDefault();
            return View(contact);
         
        }

    }
}