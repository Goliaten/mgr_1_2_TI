using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mgr_1_2_TI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Missing 'Name' field")]
        public required string Name { get; set; }
        [StringLength(512)]
        public string? Description { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}