using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
using mgr_1_2_TI.Models.ViewModels;
using mgr_1_2_TI.Structure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Controllers
{
    public class BasketController : Controller
    {
        MovieContext db;

        public BasketController(MovieContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var basket = BasketManager.GetManyFromBasket(HttpContext.Session, db);
            ViewBag.Total = BasketManager.GetSumValueFromBasket(HttpContext.Session, db);

            return View(basket);
        }
        public IActionResult AddToBasket(int id)
        {
            BasketManager.AddToBasket(HttpContext.Session, db, id);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromBasket(int id)
        {
            var model = new RemoveViewModel()
            {
                itemId = id,
                itemQuantity = BasketManager.RemoveFromBasket(HttpContext.Session, db, id),
                itemFullPrice = BasketManager.GetItemFullPrice(HttpContext.Session, db, id),
                basketSum = BasketManager.GetSumValueFromBasket(HttpContext.Session, db),
                basketCount = BasketManager.GetCount(HttpContext.Session, db)
            };
            return Json(model);
        }
    }
}