using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
using mgr_1_2_TI.Structure;
using Microsoft.AspNetCore.Mvc;

namespace mgr_1_2_TI.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        MovieContext db;

        public MenuViewComponent(MovieContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.BasketCount = GetBasketCount();
            return await Task.FromResult(View("Menu", db.T_Categories.ToList()));
        }
        public int GetBasketCount()
        {
            return BasketManager.GetCount(HttpContext.Session, db);
        }
    }
}