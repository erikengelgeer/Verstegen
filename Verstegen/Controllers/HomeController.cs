using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext db;

        public HomeController(MyContext myContext)
        {
            db = myContext;
        }

        public IActionResult Index()
        {
            ViewBag.First = db.Categories.ToList().Take(7);
            ViewBag.Second = db.Categories.ToList().Skip(7).Take(7);
            ViewBag.Themes = db.Themes.ToList();
            return View();
        }
        
    }
}
