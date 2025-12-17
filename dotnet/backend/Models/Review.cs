using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Backend.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; } = 1;

        [Required]
        [MaxLength(350)]
        public string Comment { get; set; } = string.Empty;
    }
}
