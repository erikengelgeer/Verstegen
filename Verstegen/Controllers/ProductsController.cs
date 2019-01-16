using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class ProductsController : Controller
    {
        readonly MyContext db;
        private int Amount;

        public ProductsController()
        {
            db = new MyContext();
            Amount = 6;
        }

        public IActionResult Index(int page)
        {
            if (page < 1)
            {
                page = 1;
            }

            List<string> TempTypeList = db.Products.Select(p => p.Type).Distinct().ToList();
            List<string> TypesWithCount = new List<string>();
            foreach (string s in TempTypeList)
            {
                TypesWithCount.Add(s + " (" + db.Products.Where(p => p.Type == s).Count() + ")");
            }

            ViewBag.Types = TypesWithCount;
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            ViewBag.Products = db.Products.ToList().ToPagedList(page, Amount);
            ViewBag.AmountPages = (int)Math.Ceiling((Double)db.Recipes.ToList().Count() / Amount);
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Page = page;
            return View();
        }

        public IActionResult Product(int id)
        {
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            ViewBag.Product = db.Products.SingleOrDefault(p => p.ProductId == id);
            return View();
        }

        public IActionResult Details()
        {
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            return View();
        }


        // Crud

        public IActionResult AllProducts()
        {
            ViewBag.products = db.Products.ToList();
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create", new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile photo)
        {
            //Upload image
            if (photo == null || photo.Length == 0)
            {
                product.ImgUrl = "default-image.png";
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products",
                    photo.FileName);
                var stream = new FileStream(path, FileMode.Create);

                product.ImgUrl = photo.FileName;
            }

            db.Products.Add(product);
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            db.Remove(db.Products.Find(id));
            db.SaveChanges();
            return RedirectToAction($"AllContacts");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View("Edit", db.Products.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Product product, IFormFile photo)
        {
            //Upload image
            if (photo == null || photo.Length == 0)
            {
                product.ImgUrl = db.Contacts.Find(product.ProductId).ImgUrl;
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products",
                    photo.FileName);
                var stream = new FileStream(path, FileMode.Create);

                product.ImgUrl = photo.FileName;
            }

            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction($"AllContacts");
        }
    }
}

