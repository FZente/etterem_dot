using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet.Backend.Context;

namespace dotnet.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private AppInMemoryDbContext _context;
        public ReviewController()
        {
            var options = new DbContextOptionsBuilder<AppInMemoryDbContext>()
                .UseInMemoryDatabase("MyApp_InMemory")
                .Options;

            _context = new AppInMemoryDbContext(options);
        }

        [HttpGet("count")]
        public async Task<IActionResult> Count()
        {
            int count = await _context.Reviews.CountAsync();
            return Ok(new {count});
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Reviews.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetReviewById")]
        public async Task<IActionResult> GetById(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            return review is null ? NotFound() : Ok(review);
        }
    }
}
