using SmartSocialHubServer.Domain.Entities;

namespace SmartSocialHubServer.Infrastructure.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(string email);
        Task AddAsync(User user);
        // Outros métodos conforme necessidade
    }
}
