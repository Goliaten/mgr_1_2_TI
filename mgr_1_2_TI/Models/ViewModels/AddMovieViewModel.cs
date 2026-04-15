using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgr_1_2_TI.Models.ViewModels
{
    public class AddMovieViewModel
    {
        public List<Category> Categories { get; set; }
        public Movie Movie { get; set; }
        public IFormFile Poster { get; set; }


    }
}