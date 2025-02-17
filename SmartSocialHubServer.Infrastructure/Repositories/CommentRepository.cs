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
    public class CommentRepository : ICommentRepository
    {
        private readonly SmartSocialHubDbContext _context;

        public CommentRepository(SmartSocialHubDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostAsync(int postId)
        {
            return await _context.Comments
                .Where(c => c.PostId == postId)
                .ToListAsync();
        }

        public async Task AddAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }
    }
}
