using System.Diagnostics;
using mgr_1_2_TI.DAL;
using mgr_1_2_TI.Models;
using Microsoft.AspNetCore.Mvc;

namespace mgr_1_2_TI.Controllers
{
    public class HomeController(MovieContext db) : Controller
    {
        MovieContext db = db;

        public IActionResult Index()
        {
            var categories = db.T_Categories.ToList();
            return View(categories);
        }

        public IActionResult FooterSites(string viewName)
        {
            return View(viewName);
        }
    }
}
