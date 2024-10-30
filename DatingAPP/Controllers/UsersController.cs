using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers() {
            var users = _context.Users.ToList();
            return Ok(users);
        }
        [HttpGet("{id:int}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var users = _context.Users.Find(id);
            if (User == null)
                return NotFound();
            return Ok(users);
        }


    }
}
