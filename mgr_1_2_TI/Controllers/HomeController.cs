using System.Diagnostics;
using mgr_1_2_TI.Models;
using Microsoft.AspNetCore.Mvc;

namespace mgr_1_2_TI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
