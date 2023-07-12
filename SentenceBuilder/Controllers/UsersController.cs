using Microsoft.AspNetCore.Mvc;
using SentenceBuilder.Data;

namespace SentenceBuilder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        // {
        //     var users = await _context.Users.ToListAsync();

        //     return users;
        // }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppUser>> GetUser(int id)
        // {
        //     return await _context.Users.FindAsync(id); // has to be the primary key to use Find
        // }

    }
}