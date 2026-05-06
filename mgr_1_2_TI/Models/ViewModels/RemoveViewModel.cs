using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgr_1_2_TI.Models.ViewModels
{
    public class RemoveViewModel
    {
        public int itemId { get; set; }
        public int itemQuantity { get; set; }
        public decimal itemFullPrice { get; set; }
        public decimal? basketSum { get; set; }
        public int basketCount { get; set; }
    }
}