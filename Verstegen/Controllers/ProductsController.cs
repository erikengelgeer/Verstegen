using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product(string product)
        {
            ViewData["productname"] = product;
            return View();
        }
    }
}
