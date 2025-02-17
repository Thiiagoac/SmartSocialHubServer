using SmartSocialHubServer.Domain.Entities;

namespace SmartSocialHubServer.Infrastructure.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPostsAsync();
        Task AddAsync(Post post);
    }
}
