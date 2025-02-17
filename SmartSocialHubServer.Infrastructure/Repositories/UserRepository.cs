using Microsoft.EntityFrameworkCore;
using SmartSocialHubServer.Domain.Entities;
using SmartSocialHubServer.Infrastructure.Data;
using SmartSocialHubServer.Infrastructure.Repositories.Interfaces;


namespace SmartSocialHubServer.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SmartSocialHubDbContext _context;

        public UserRepository(SmartSocialHubDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
