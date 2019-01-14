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
        readonly MyContext db;

        public HomeController()
        {
            db = new MyContext();
        }

        public IActionResult Index()
        {
            ViewBag.Themes = db.Themes.ToList();         
            return View();
        }
        
    }
}
