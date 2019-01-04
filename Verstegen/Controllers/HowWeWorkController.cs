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
            BlogData data = new BlogData();
            List<Blog> blogs = data.getBlogs();
            
            ViewBag.Blogs = blogs;
            return View("HowWeWork", blogs);
        }
    }
}
