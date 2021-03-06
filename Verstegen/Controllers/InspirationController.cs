using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class InspirationController : Controller
    {
        private readonly MyContext db;
        private int Amount;

        public InspirationController(MyContext myContext)
        {
            db = myContext;
            Amount = 6;
        }

        public IActionResult Index(int page, int? id)
        {
            if (page < 1)
            {
                page = 1;
            }

            if (id != null)
            {
                Category cat = db.Categories.Single(c => c.CategoryId == id);
                ViewBag.Category = cat;
                ViewBag.Recipes = db.Recipes.Where(r => cat.CategoryId == r.CategoryId).Distinct().ToList().ToPagedList(page, Amount);
                ViewBag.Products = db.Products.Where(p => p.CategoryId == cat.CategoryId).Distinct().ToList().ToPagedList(page, Amount);
                ViewBag.AmountPages = (int)Math.Ceiling(((Double)db.Recipes.Where(r => cat.CategoryId == r.CategoryId).Distinct().ToList().Count() + db.Products.Where(p => p.CategoryId == cat.CategoryId).Distinct().ToList().Count()) / Amount);
            }
            else
            {
                ViewBag.Welcome = "Welcome bij inspiration";
                ViewBag.Recipes = db.Recipes.ToList().ToPagedList(page, Amount);
                ViewBag.Products = db.Products.ToList().ToPagedList(page, Amount);
                ViewBag.AmountPages = (int)Math.Ceiling(((Double)db.Recipes.Distinct().ToList().Count() + db.Products.Distinct().ToList().Count()) / Amount);
            }

            List<string> TempTypeList = db.Recipes.Select(r => r.Type).Distinct().ToList();
            List<string> TypesWithCount = new List<string>();
            foreach (string s in TempTypeList)
            {
                TypesWithCount.Add(s + " (" + db.Recipes.Where(r => r.Type == s).Count() + ")");
            }

            List<Product> products = db.Products.Where(p => p.CategoryId == id).ToList();
                        
            ViewBag.Types = TypesWithCount;
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Page = page;

            return View();
        }

        public IActionResult Theme(int id)
        {
            if (id < 0)
            {
                return RedirectToAction("Index", new RouteValueDictionary(
                                    new { controller = "Inspiration", action = "Index", Id = 0, Page = 1 }));
            }
            else
            {
                ViewBag.Recipes = db.Recipes.Where(r => r.ThemeId == id).ToList();
                ViewBag.Theme = db.Themes.Where(r => r.ThemeId == id).SingleOrDefault();
                ViewBag.Blogs = db.Blogs.ToList();

                return View();
            }
        }

        public IActionResult Details(int id)
        {
            if(!db.Blogs.Any(b => b.BlogId == id))
            {
                return RedirectToAction("Index", new RouteValueDictionary(
                                    new { controller = "Inspiration", action = "Index", Id = 0, Page = 1 }));
            }
            else
            {
                Blog blog = db.Blogs.Where(b => b.BlogId == id).SingleOrDefault();
                return View(blog);
            }
        }
    }
}