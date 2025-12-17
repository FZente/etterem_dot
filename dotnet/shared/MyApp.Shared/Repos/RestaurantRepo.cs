using MyApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Repos
{
    public class RestaurantRepo
    {
        private List<Restaurant> _items = new()
        {
            new Restaurant
            {
                Id = 1,
                Name = "Tasty Grill",
                Description = "Kiváló grillételek és hamburgerek.",
                Location = "Budapest",
                AverageRating = 5
            },
            new Restaurant
            {
                Id = 2,
                Name = "Pasta House",
                Description = "Tradicionális olasz tészták és desszertek.",
                Location = "Szeged",
                AverageRating = 4
            },
            new Restaurant
            {
                Id = 3,
                Name = "Green Garden",
                Description = "Egészséges, vegetáriánus ételek.",
                Location = "Debrecen",
                AverageRating = 4
            }
        };

        public IReadOnlyList<Restaurant> GetAll()
        {
            return _items.ToList();
        }

        public void Add(Restaurant restaurant)
        {
            if (restaurant.Id == 0)
            {
                restaurant.Id = _items.Count == 0 ? 1 : _items.Max(r => r.Id) + 1;
            }
            _items.Add(restaurant);
        }

        public void Remove( Restaurant restaurant)
        {
            _items.Remove( restaurant );
        }
    }
}
