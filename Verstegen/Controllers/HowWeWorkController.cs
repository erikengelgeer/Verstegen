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
        readonly MyContext db;

        public HowWeWorkController()
        {
            db = new MyContext();
        }

        public IActionResult Index()
        {
            ViewBag.Blogs = db.Categorys
             .Where(m => m.CategoryValue == "hww")
             .SelectMany(m => m.BlogsInProject.Select(mc => mc.Blog))
             .ToList();
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();    
            return View();
        }
    }
}
