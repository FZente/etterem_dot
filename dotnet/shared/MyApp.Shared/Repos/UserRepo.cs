using MyApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Repos
{
    public class UserRepo
    {
        private List<User> _users = new()
        {
            new User
            {
                Id = 1,
                Name = "Béla",
                Email = "bela@gmail.com",
                Password = "password",
            },
            new User
            {
                Id = 2,
                Name = "Sanyi",
                Email = "sanyi@gmail.com",
                Password = "sanyi1",
            },
            new User
            {
                Id = 3,
                Name = "Anna",
                Email = "anna@gmail.com",
                Password = "anna",
            }
        };

        public IReadOnlyList<User> GetAll()
        {
            return _users.ToList();
        }

        public void Add(User user)
        {
            if (user.Id == 0)
            {
                user.Id = _users.Count == 0 ? 1 : _users.Max(r => r.Id) + 1;
            }
            _users.Add(user);
        }

        public void Remove(User user)
        {
            _users.Remove(user);
        }
    }
}
