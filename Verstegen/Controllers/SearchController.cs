﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using PagedList;

namespace Verstegen.Controllers
{
    public class SearchController : Controller
    {
        readonly MyContext db;

        List<Object> resultList;

        public SearchController()
        {
            db = new MyContext();
            resultList = new List<object>();
        }

        public IActionResult Index(string result)
        {
            ViewBag.Search = result;

            var local1 = db.Blogs.Where(b => b.Title.Contains(result) || b.SubTitle.Contains(result) || b.Text.Contains(result) || b.SubTitle.Contains(result)).ToList();
            var local2 = db.Recipes.Where(r => r.Title.Contains(result) || r.Type.Contains(result)).ToList();

            resultList = (from x in local1 select (Object)x).ToList();
            resultList.AddRange((from x in local2 select (Object)x).ToList());

            ViewBag.resultList = resultList;
            ViewBag.count = resultList.Count();
            return View();
        }
    }
}