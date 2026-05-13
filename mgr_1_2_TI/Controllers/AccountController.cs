using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Controllers
{
    public class AccountController : Controller
    {
        public AccountController(UserManager<WebUser> userManager, SignInManager<WebUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        UserManager<WebUser> userManager { get; }
        SignInManager<WebUser> signInManager { get; }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Register()
        {
            string login = "aaa";
            string password = "1234";
            var user = await userManager.FindByNameAsync(login);
            if (user == null)
            {
                try
                {
                    user = new WebUser()
                    {
                        UserName = login,
                        FirstName = "Grzegorz",
                        LastName = "Brzęczyszczykiewicz",
                        Email = "janpatdrugi@mail.to",
                        Address = "Chrząszczyszewoszyce powiat Łękołody"
                    };
                    await userManager.CreateAsync(user, password);
                    ViewBag.Message = "Użytkownik stworzony";
                }
                catch (Exception e)
                {
                    ViewBag.Message = $"Błąd podczas tworzenia użytkownika: {e.Message}";
                }

            }
            else
            {
                ViewBag.Message = "Użytkownik niestworzony. Już istnieje";
            }

            return View();
        }
    }
}