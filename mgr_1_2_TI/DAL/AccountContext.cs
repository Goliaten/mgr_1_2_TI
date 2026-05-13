using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace mgr_1_2_TI.DAL
{
    public class AccountContext : IdentityDbContext<WebUser, WebUserRole, int>
    {
        public AccountContext(DbContextOptions options) : base(options)
        {
        }

        protected AccountContext()
        {
        }
    }
}