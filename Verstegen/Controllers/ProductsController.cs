﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verstegen.Models;
using X.PagedList;

namespace Verstegen.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MyContext db;
        private int Amount;

        public ProductsController(MyContext myContext)
        {
            db = myContext;
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
    }
}

