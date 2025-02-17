using SmartSocialHubServer.Domain.Entities;


namespace SmartSocialHubServer.Infrastructure.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsByPostAsync(int postId);
        Task AddAsync(Comment comment);
    }
}
