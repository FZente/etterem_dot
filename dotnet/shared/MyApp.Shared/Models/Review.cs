using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Shared.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RestaurantId { get; set; }

        public int Rating { get; set; } = 1;

        public string Comment { get; set; } = string.Empty;
    }
}
