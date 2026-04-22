using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
using mgr_1_2_TI.Structure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Controllers
{
    [Route("[controller]")]
    public class BasketController : Controller
    {
        MovieContext db;

        public BasketController(MovieContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var basket = BasketManager.GetManyFromCart(HttpContext.Session, db);
            ViewBag.Total = BasketManager.GetSumValueFromCart(HttpContext.Session, db);

            return View(basket);
        }
        public IActionResult AddToBasket(int id)
        {
            BasketManager.AddToCart(HttpContext.Session, db, id);
            return RedirectToAction("Index");
        }
    }
}