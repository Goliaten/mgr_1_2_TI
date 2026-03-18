using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
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
            return await Task.FromResult(View("Menu", db.T_Categories.ToList())); // # FIXME missing view name 
        }
    }
}