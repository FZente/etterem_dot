using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Backend.Context;

namespace MyApp.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private AppInMemoryDbContext _context;
        public RestaurantController()
        {
            var options = new DbContextOptionsBuilder<AppInMemoryDbContext>()
                .UseInMemoryDatabase("MyApp_InMemory")
                .Options;

            _context = new AppInMemoryDbContext(options);
        }

        [HttpGet("count")]
        public async Task<IActionResult> Count()
        {
            int count = await _context.Restaurants.CountAsync();
            return Ok(new { count });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Restaurants.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetRestaurantById")]
        public async Task<IActionResult> GetById(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            return restaurant is null ? NotFound() : Ok(restaurant);
        }
    }
}
