using Microsoft.EntityFrameworkCore;
using bankapplication.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using bankapplication.Data;

namespace bankapplication.Features
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public async void RemoveUser(int Id)
        {
            var requesteduser = await _context.Users.FindAsync(Id);
            if (requesteduser != null)
                _context.Users.Remove(requesteduser);
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }

    }
}
