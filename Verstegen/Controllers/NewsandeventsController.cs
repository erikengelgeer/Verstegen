using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class NewsandeventsController : Controller
    {
        private readonly MyContext db;

        public NewsandeventsController(MyContext myContext)
        {
            db = myContext;
        }

        public IActionResult Index()
        {
            ViewBag.News = db.Blogs.Where(b => b.Type == "hww").ToList();
            //ViewBag.News = db.Blogs.Where(b => b.Type == "news" || b.Type == "story").ToList();
            return View();
        }
    }
}
