using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mgr_1_2_TI.ViewComponents
{
    public class SideMenuViewComponent : ViewComponent
    {
        MovieContext db;

        public SideMenuViewComponent(MovieContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            // var category = db.T_Categories.Find(categoryId);
            var category = db.T_Categories.Include(c => c.Movies).Where(c => c.Id == categoryId).Single();
            var categoryMovies = category.Movies.ToList();

            return await Task.FromResult(View("_SideMenu", categoryMovies));
        }
    }
}