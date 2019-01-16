using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class SearchController : Controller
    {
        readonly MyContext db;

        List<Object> resultList;

        int Amount;

        public SearchController()
        {
            db = new MyContext();
            resultList = new List<object>();
            Amount = 2;
        }

        public IActionResult Index(string result, int page)
        {
            if(page < 1)
            {
                page = 1;
            }

            ViewBag.Search = result;

            var local1 = db.Blogs.Where(b => b.Title.Contains(result) || b.SubTitle.Contains(result) || b.Text.Contains(result) || b.SubTitle.Contains(result)).ToList();
            var local2 = db.Recipes.Where(r => r.Title.Contains(result) || r.Type.Contains(result)).ToList();
            var local3 = db.Products.Where(p => p.Title.Contains(result)).ToList();

            resultList = (from x in local1 select (Object)x).ToList();
            resultList.AddRange((from x in local2 select (Object)x).ToList());
            resultList.AddRange((from x in local3 select (Object)x).ToList());

            ViewBag.resultList = resultList.ToPagedList(page, Amount);
            ViewBag.AmountPages = (int)Math.Ceiling((Double)resultList.Count() / Amount);
            ViewBag.Page = page;
            ViewBag.Result = result;
            return View();
        }
    }
}