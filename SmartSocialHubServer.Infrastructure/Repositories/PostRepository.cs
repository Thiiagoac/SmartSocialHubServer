using Microsoft.EntityFrameworkCore;
using SmartSocialHubServer.Domain.Entities;
using SmartSocialHubServer.Infrastructure.Data;
using SmartSocialHubServer.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSocialHubServer.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SmartSocialHubDbContext _context;

        public PostRepository(SmartSocialHubDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task AddAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
        }
    }
}
