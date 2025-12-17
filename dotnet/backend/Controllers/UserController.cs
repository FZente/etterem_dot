using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet.Backend.Context;

namespace dotnet.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private AppInMemoryDbContext _context;
        public UserController()
        {
            var options = new DbContextOptionsBuilder<AppInMemoryDbContext>()
                .UseInMemoryDatabase("MyApp_InMemory")
                .Options;

            _context = new AppInMemoryDbContext(options);
        }

        [HttpGet("count")]
        public async Task<IActionResult> Count()
        {
            int count = await _context.Users.CountAsync();
            return Ok(new { count });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetStudentById")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user is null ? NotFound() : Ok(user);
        }
        
    }
}
