using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class RecipesController : Controller
    {
        private readonly MyContext db;

        private int Amount;

        public RecipesController(MyContext myContext)
        {
            db = myContext;
            Amount = 6;
        }

        public IActionResult Index(int page)
        {
            if(page < 1)
            {
                page = 1;
            }

            List<string> TempTypeList = db.Recipes.Select(r => r.Type).Distinct().ToList();
            List<string> TypesWithCount = new List<string>();
            foreach(string s in TempTypeList)
            {
                TypesWithCount.Add(s + " (" + db.Recipes.Where(r => r.Type == s).Count() + ")");
            }

            ViewBag.Types = TypesWithCount;
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();

            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Recipes = db.Recipes.ToList().ToPagedList(page, Amount);
            ViewBag.AmountPages = (int) Math.Ceiling((Double)db.Recipes.ToList().Count() / Amount);
            ViewBag.Page = page;
            return View();
        }

        public IActionResult Recipe(int id)
        {
            if (id < 0)
            {
                return RedirectToAction("/Recipes");
            }
            else
            {
                ViewBag.Ingredients = db.Ingredients.Where(i => i.RecipeId == id).ToList();
                ViewBag.Recipe = db.Recipes.SingleOrDefault(r => r.RecipeId == id);
                return View();
            }
        }
    }
}