using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Password { get; set; } = string.Empty;
    }
}
