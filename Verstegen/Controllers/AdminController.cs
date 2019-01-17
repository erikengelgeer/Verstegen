using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;

namespace Verstegen.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyContext db;

        public AdminController(MyContext myContext)
        {
            db = myContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        // Products CRUD
        public IActionResult AllProducts()
        {
            ViewBag.products = db.Products.ToList();
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View("CreateProduct", new Product());
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            ViewBag.Catergory = db.Products.ToList();

            db.Products.Add(product);
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            db.Remove(db.Products.Find(id));
            db.SaveChanges();
            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            return View("EditProduct", db.Products.Find(id));
        }

        [HttpPost]
        public IActionResult EditProduct(int id, Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }

        // Contacts CRUD
        public IActionResult AllContacts()
        {
            ViewBag.contacts = db.Contacts.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View("CreateContact", new Contact());
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            //Upload image
            //if (photo == null || photo.Length == 0)
            //{
            //    contact.ImgUrl = "default-avatar.png";
            //}
            //else
            //{
            //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/contacts",
            //        photo.FileName);
            //    var stream = new FileStream(path, FileMode.Create);

            //    contact.ImgUrl = photo.FileName;
            //}

            db.Contacts.Add(contact);
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult DeleteContact(int id)
        {
            db.Remove(db.Contacts.Find(id));
            db.SaveChanges();
            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            return View("EditContact", db.Contacts.Find(id));
        }

        [HttpPost]
        public IActionResult EditContact(int id, Contact contact)
        {
            //Upload image
            //if (photo == null || photo.Length == 0)
            //{
            //    contact.ImgUrl = db.Contacts.Find(contact.ContactId).ImgUrl;
            //}
            //else
            //{
            //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/contacts",
            //        photo.FileName);
            //    var stream = new FileStream(path, FileMode.Create);

            //    contact.ImgUrl = photo.FileName;
            //}

            db.Update(contact);
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }

        // Recipes Crud
        public IActionResult AllRecipes()
        {
            ViewBag.recipes = db.Recipes.ToList();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Themes = db.Categories.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult CreateRecipe()
        {
            return View("CreateRecipe", new Recipe());
        }

        [HttpPost]
        public IActionResult CreateRecipe(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();

            return RedirectToAction($"AllRecipes");
        }

        [HttpGet]
        public IActionResult DeleteRecipe(int id)
        {
            db.Remove(db.Recipes.Find(id));
            db.SaveChanges();
            return RedirectToAction($"AllRecipes");
        }

        [HttpGet]
        public IActionResult EditRecipe(int id)
        {
            return View("EditRecipe", db.Recipes.Find(id));
        }

        [HttpPost]
        public IActionResult EditRecipe(int id, Recipe recipe)
        {
            db.Update(recipe);
            db.SaveChanges();

            return RedirectToAction($"AllRecipes");
        }
    }
}