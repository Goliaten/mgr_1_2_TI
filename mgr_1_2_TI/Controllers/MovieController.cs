using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.DAL;
using mgr_1_2_TI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Controllers
{
    public class MovieController : Controller
    {
        MovieContext db;

        public MovieController(MovieContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryMovies(string category)
        {
            var category_db = db.T_Categories.Include("Movies").Where(c => c.Name.ToLower() == category.ToLower()).Single();
            var movies = category_db.Movies.ToList();

            return View(movies);
        }

        public IActionResult All()
        {
            var movies = db.T_Movies.ToList();
            return View(movies);
        }

        public IActionResult Details(int movieId)
        {
            Console.WriteLine(movieId);
            var movie = db.T_Movies.Find(movieId);
            Console.WriteLine(movieId);
            _ = db.T_Categories.Find(movie?.CategoryId);
            Console.WriteLine(movieId);

            return View(movie);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            var model = new AddMovieViewModel
            {
                Categories = db.T_Categories.ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieViewModel model)
        {
            return View();
        }

    }
}