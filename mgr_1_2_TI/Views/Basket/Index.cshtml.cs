using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Views.Movie
{
    public class Index : PageModel
    {
        private readonly ILogger<Details> _logger;

        public Index(ILogger<Details> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}