using Microsoft.EntityFrameworkCore;
using System;
using NatureHub2.Models;

namespace NatureHub2.Repos
{
    public class UserRepo : Repository<User>, IUserRepo
    {
        public UserRepo(HubDb2Context context) : base(context) { }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
