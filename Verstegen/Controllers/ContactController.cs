using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
