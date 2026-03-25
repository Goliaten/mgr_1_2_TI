using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mgr_1_2_TI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Missing 'Title' field")]
        public required string Title { get; set; }
        [StringLength(512)]
        public string? Description { get; set; }
        public string? Director { get; set; }
        [Required(ErrorMessage = "Missing 'Price' field")]
        public decimal Price { get; set; }
        // [ForeignKey('Category')]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}