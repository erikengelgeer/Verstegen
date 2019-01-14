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

        public IActionResult Theme(int id)
        {
            ViewBag.Recipes = db.Recipes.Where(r=> r.ThemeId == id).ToList();
            ViewBag.Theme = db.Themes.Where(r => r.ThemeId == id).SingleOrDefault();
            ViewBag.Blogs = db.Blogs.ToList();

            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}