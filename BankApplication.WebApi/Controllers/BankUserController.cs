using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bankapplication.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankApplication.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankUserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BankUserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}

