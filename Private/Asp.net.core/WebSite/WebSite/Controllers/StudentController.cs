using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class StudentController : Controller
    {
        private readonly WebSiteDbcontext _context;
        public StudentController(WebSiteDbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Student.Include("Group").ToList();
            return View(students);
        }

        public void FiilGroups()
        {
            ViewBag.Group = _context.Group.Select(g => new SelectListItem
            {
                Text = g.Name,
                Value = g.Id.ToString()
            }).ToList();
        }
        [HttpGet]
        public IActionResult Create()
        {
            FiilGroups();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (_context.Student.Any(n => n.Name == student.Name))
            {
                ModelState.AddModelError("Name", "Bu ad artiq movcuddur");
            }
            if (ModelState.IsValid)
            {
                _context.Student.Add(student);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            FiilGroups();
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            var student = _context.Student.Find(id);

            if (student == null) return NotFound();
            _context.Student.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("index");
           
        }

        public IActionResult Edit(int id)
        {
            var student = _context.Student.Include("Group").FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            FiilGroups();
            return View(student);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            FiilGroups();
            return View(student);
        }
    }
}