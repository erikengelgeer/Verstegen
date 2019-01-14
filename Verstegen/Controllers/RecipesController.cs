using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class RecipesController : Controller
    {
        readonly MyContext db;

        public RecipesController()
        {
            db = new MyContext();
        }

        public IActionResult Index()
        {
            List<string> TempTypeList = db.Recipes.Select(r => r.Type).Distinct().ToList();
            List<string> TypesWithCount = new List<string>();
            foreach(string s in TempTypeList)
            {
                TypesWithCount.Add(s + " (" + db.Recipes.Where(r => r.Type == s).Count() + ")");
            }

            ViewBag.Types = TypesWithCount;
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            ViewBag.Recipes = db.Recipes.ToList();
            ViewBag.Categories = db.Categories.ToList();
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