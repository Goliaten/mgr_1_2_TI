using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgr_1_2_TI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}