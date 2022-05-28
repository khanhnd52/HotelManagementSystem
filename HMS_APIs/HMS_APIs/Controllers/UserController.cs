using HMS_APIs.Data;
using HMS_APIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMS_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> get()
        {
            return _context.User.ToList();
        }
    }
}
