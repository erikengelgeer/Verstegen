using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class RecipesController : Controller
    {
        readonly MyContext db;

        private int Amount;

        public RecipesController()
        {
            db = new MyContext();
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

        //Crud

        public IActionResult AllRecipes()
        {
            ViewBag.recipes = db.Recipes.ToList();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Themes = db.Categories.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create", new Recipe());
        }

        [HttpPost]
        public IActionResult Create(Recipe recipe, IFormFile photo)
        {
            //Upload image
            if (photo == null || photo.Length == 0)
            {
                recipe.ImgUrl = "default-avatar.png";
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/recipes",
                    photo.FileName);
                var stream = new FileStream(path, FileMode.Create);

                recipe.ImgUrl = photo.FileName;
            }

            db.Recipes.Add(recipe);
            db.SaveChanges();

            return RedirectToAction($"AllRecipes");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            db.Remove(db.Recipes.Find(id));
            db.SaveChanges();
            return RedirectToAction($"AllRecipes");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View("Edit", db.Recipes.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Recipe recipe, IFormFile photo)
        {
            //Upload image
            if (photo == null || photo.Length == 0)
            {
                recipe.ImgUrl = db.Recipes.Find(recipe.RecipeId).ImgUrl;
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/recipes",
                    photo.FileName);
                var stream = new FileStream(path, FileMode.Create);

                recipe.ImgUrl = photo.FileName;
            }

            db.Update(recipe);
            db.SaveChanges();

            return RedirectToAction($"AllRecipes");
        }
    }
}