using SmartSocialHubServer.Domain.Entities;


namespace SmartSocialHubServer.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string email, string password);
        Task<User> RegisterAsync(User user, string password);
    }
}
