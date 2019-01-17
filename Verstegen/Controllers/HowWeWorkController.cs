using System;
using System.Collections;
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
        private readonly MyContext db;

        public HowWeWorkController(MyContext myContext)
        {
            db = myContext;
        }

        public IActionResult Index()
        {
            ViewBag.Blogs = db.Blogs.Where(b=> b.Type == "hww").ToList();
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();   
            return View();
        }
    }
}
