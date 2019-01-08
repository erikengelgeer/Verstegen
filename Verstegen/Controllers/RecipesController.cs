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
            ViewBag.Contact = db.Contacts.OrderBy(c => Guid.NewGuid()).Skip(0).Take(1).First();
            return View();
        }
    }
}