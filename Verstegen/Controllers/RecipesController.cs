﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Verstegen.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}