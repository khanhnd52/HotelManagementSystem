using HMS_APIs.Data;
using HMS_APIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMS_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Room> get()
        {
            return _context.Room.ToList();
        }
        [HttpPost]
        public Room Post([FromQuery] Room Room)
        {
            _context.Add(Room);
            _context.SaveChanges();
            return Room;
        }
    }
}