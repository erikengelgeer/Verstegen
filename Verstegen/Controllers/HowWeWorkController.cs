using System;
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
        public IActionResult Index()
        {
            GetData data = new GetData();
            
            ViewBag.Blogs = data.getBlogs();
            ViewBag.Contact = data.GetContact();
            return View("HowWeWork");
        }
    }
}
