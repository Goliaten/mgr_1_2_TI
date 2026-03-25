using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace mgr_1_2_TI.Views.Shared.Components
{
    public class SideMenu : PageModel
    {
        private readonly ILogger<SideMenu> _logger;

        public SideMenu(ILogger<SideMenu> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}