using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Extentions;
using FinalProject.Models;
using FinalProject.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FinalProject.Areas.FinalArea.Controllers
{
    [Area("FinalArea")]
    [Authorize(Roles = "Admin")]
    public class ContactPageController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;
        public ContactPageController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: ContactPage
        public IActionResult Index()
        {
            return View(_context.Contacts);
        }

        // GET: ContactPage/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Contact contact =await _context.Contacts.FindAsync(id);
            if (contact == null) return NotFound();
            return View(contact);
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null) return NotFound();
            return View(contact);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Contact contact)
        {
            if (id == null) return NotFound();

            Contact dbContact = await _context.Contacts.FindAsync(id);
            if (dbContact == null) return RedirectToAction(nameof(Index));

            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Description"].ValidationState == ModelValidationState.Invalid ||
                ModelState["MobilePhone"].ValidationState == ModelValidationState.Invalid ||
                ModelState["HomePhone"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Email"].ValidationState == ModelValidationState.Invalid)
            {
                return View(dbContact);
            }

            if (contact.UpdatePhoto != null)
            {
                if (!contact.UpdatePhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Bu fayl şəkil formatında deyil");
                    return View();
                }
                if (!contact.UpdatePhoto.CheckImageSize(1))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 1 MB-dan çox ola bilməz");
                    return View();

                }
                string filename = await contact.UpdatePhoto.CopyImage(_env.WebRootPath, "contact");
                Utility.DeleteImageFromFolder(_env.WebRootPath, dbContact.BackImage);

                dbContact.BackImage = filename;
            }
            dbContact.Description = contact.Description;
            dbContact.HomePhone = contact.HomePhone;
            dbContact.MobilePhone = contact.MobilePhone;
            dbContact.Email = contact.Email;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}