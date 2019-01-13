using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class InspirationController : Controller
    {
        readonly MyContext db;

        public InspirationController()
        {
            db = new MyContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Theme()
        {
            ViewBag.Recipes = db.Recipes.ToList();
            ViewBag.Blogs = db.Blogs.ToList();

            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}