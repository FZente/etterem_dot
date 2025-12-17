using MyApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Repos
{
    public class ReviewRepo
    {
        private List<Review> _items = new()
        {
            new Review
            {
                Id = 1,
                RestaurantId = 1,
                UserId = 1,
                Rating = 1,
                Comment = "Nem volt jó!"
            },
            new Review
            {
                Id = 2,
                RestaurantId = 2,
                UserId = 2,
                Rating = 3,
                Comment = "Elment!"
            },
            new Review
            {
                Id = 3,
                RestaurantId = 3,
                UserId = 3,
                Rating = 5,
                Comment = "Finom volt!"
            }
        };

        public IReadOnlyList<Review> GetAll()
        {
            return _items.ToList();
        }

        public void Add(Review review)
        {
            if (review.Id == 0)
            {
                review.Id = _items.Count == 0 ? 1 : _items.Max(r => r.Id) + 1;
            }
            _items.Add(review);
        }

        public void Remove(Review review)
        {
            _items.Remove(review);
        }
    }
}
