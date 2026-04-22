using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.Models;

namespace mgr_1_2_TI.Structure
{
    public class BasketItem
    {
        public required Movie Movie { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal FullPrice { get; set; }
    }
}