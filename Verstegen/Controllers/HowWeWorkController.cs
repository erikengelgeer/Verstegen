using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class HowWeWorkController : Controller
    {
        readonly MyContext db;

        public HowWeWorkController()
        {
            db = new MyContext();
        }

        public IActionResult Index()
        {
            ViewBag.Blogs = db.Blogs.ToList();
            ViewBag.Contact = db.Contacts.First();    
            return View();
        }
    }
}
