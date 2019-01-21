﻿using System;
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
        private readonly MyContext db;

        List<Object> resultList;

        int Amount;

        public SearchController(MyContext myContext)
        {
            db = myContext;
            resultList = new List<object>();
            Amount = 6;
        }

        public IActionResult Index(string result, int page)
        {
            if(page < 1)
            {
                page = 1;
            }

            ViewBag.Search = result;

            var blogList = db.Blogs.Where(b => b.Title.Contains(result) || b.Subject.Contains(result) || b.SubTitle.Contains(result) || b.Text.Contains(result) || b.Quote.Contains(result) || b.QuoteFrom.Contains(result) || b.SubText.Contains(result) || b.Date.ToString().Contains(result) || b.Type.Contains(result)).ToList();
            var recipeList = db.Recipes.Where(r => r.Title.Contains(result) || r.SubTitle.Contains(result) || r.Type.Contains(result) || r.AmountOfPeople.Contains(result) || r.Procedure.Contains(result) || r.Decoration.Contains(result) || r.Ingredients.Any(a => a.Name.Contains(result) || a.Gram.ToString().Contains(result) || a.ArticleNumber.ToString().Contains(result) || a.Percentage.ToString().Contains(result))).ToList();
            var productList = db.Products.Where(p => p.Title.Contains(result) || p.Type.Contains(result) || p.Description.Contains(result) || p.Contents.Contains(result) || p.AltString.Contains(result) || p.ProductDetails.Contains(result)).ToList();

            resultList = (from x in blogList select (Object)x).ToList();
            resultList.AddRange((from x in recipeList select (Object)x).ToList());
            resultList.AddRange((from x in productList select (Object)x).ToList());

            ViewBag.TestList = resultList;

            ViewBag.resultList = resultList.ToPagedList(page, Amount);
            ViewBag.AmountPages = (int)Math.Ceiling((Double)resultList.Count() / Amount);
            ViewBag.Page = page;
            ViewBag.Result = result;

            return View();
        }
    }
}
