using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class ProductsController : Controller
    {
        readonly MyContext db;

        public ProductsController()
        {
            db = new MyContext();
        }

        public IActionResult Index()
        {
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            return View();
        }

        public IActionResult Product(string product)
        {
            ViewData["productname"] = product;
            return View();
        }

        public IActionResult Details()
        {
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            return View();
        }
    }
}

