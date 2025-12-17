using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet.Backend.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Location {  get; set; } = string.Empty;

        [Range(1, 5)]
        public int AverageRating { get; set; } = 1;
    }
}
