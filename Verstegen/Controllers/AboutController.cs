using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Verstegen.Controllers
{
    public class AboutController : Controller
    {
        readonly MyContext db;

        public AboutController()
        {
            db = new MyContext();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Blogs = db.Blogs.ToList();
            ViewBag.Recipes = db.Recipes.ToList();
            return View();
        }
    }
}
