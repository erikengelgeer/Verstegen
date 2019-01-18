using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class NewsandeventsController : Controller
    {
        private readonly MyContext db;

        List<Blog> news;

        int amount;

        public NewsandeventsController(MyContext myContext)
        {
            db = myContext;
            news = new List<Blog>();
            amount = 8;
        }

        public IActionResult Index(int page)
        {
            if (page < 1)
            {
                page = 1;
            }

            news = db.Blogs.Where(b => b.Type == "news" || b.Type == "story").ToList();

            ViewBag.News = news.ToPagedList(page, amount);
            ViewBag.AmountPages = (int)Math.Ceiling((Double)news.Count() / amount);
            ViewBag.Page = page;

            return View();
        }
    }
}
