using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Views.Movie
{
    public class AddMovie : PageModel
    {
        private readonly ILogger<AddMovie> _logger;

        public AddMovie(ILogger<AddMovie> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}