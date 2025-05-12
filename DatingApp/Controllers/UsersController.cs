using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
            // Constructor logic here

        }

        [HttpGet]
        public async Task<ActionResult <IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync ();
        }

        //api/users/
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
           return await _context.Users.FindAsync(id);
            
        }
    }
}
