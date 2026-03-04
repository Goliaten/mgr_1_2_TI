using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.Models;
using Microsoft.EntityFrameworkCore;

namespace mgr_1_2_TI.DAL
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> T_Movies { get; set; }
        public DbSet<Category> T_Categories { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            
        }

        protected MovieContext()
        {
        }
    }
}