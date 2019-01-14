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
            List<string> TempTypeList = db.Products.Select(p => p.Type).Distinct().ToList();
            List<string> TypesWithCount = new List<string>();
            foreach (string s in TempTypeList)
            {
                TypesWithCount.Add(s + " (" + db.Products.Where(p => p.Type == s).Count() + ")");
            }

            ViewBag.Types = TypesWithCount;
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            ViewBag.Products = db.Products.ToList();
            ViewBag.Categories = db.Categories.ToList();
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

