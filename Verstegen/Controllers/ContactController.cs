using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Verstegen.Controllers
{
    public class ContactController : Controller
    {
        readonly MyContext db;

        public ContactController()
        {
            db = new MyContext();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Contact> ContactLijst = db.Contacts.ToList();

            //ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            return View(ContactLijst);
        }
        
        public IActionResult AllContacts()
        {
            ViewBag.contacts = db.Contacts.ToList();
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create", new Contact());
        }

        [HttpPost]
        public IActionResult Create(Contact contact, IFormFile photo)
        {
            //Upload image
            if (photo == null || photo.Length == 0)
            {
                contact.ImgUrl = "default-avatar.png";
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/contacts",
                    photo.FileName);
                var stream = new FileStream(path, FileMode.Create);

                contact.ImgUrl = photo.FileName;
            }

            db.Contacts.Add(contact);
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            db.Remove(db.Contacts.Find(id));
            db.SaveChanges();
            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View("Edit", db.Contacts.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Contact contact, IFormFile photo)
        {
            //Upload image
            if (photo == null || photo.Length == 0)
            {
                contact.ImgUrl = db.Contacts.Find(contact.ContactId).ImgUrl;
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/contacts",
                    photo.FileName);
                var stream = new FileStream(path, FileMode.Create);

                contact.ImgUrl = photo.FileName;
            }

            db.Update(contact);
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }
    }
}
