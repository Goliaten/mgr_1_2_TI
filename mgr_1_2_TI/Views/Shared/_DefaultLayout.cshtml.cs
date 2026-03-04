using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Views.Shared
{
    public class _DefaultLayout : PageModel
    {
        private readonly ILogger<_DefaultLayout> _logger;

        public _DefaultLayout(ILogger<_DefaultLayout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}