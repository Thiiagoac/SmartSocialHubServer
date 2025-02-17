using SmartSocialHubServer.Application.Interfaces;
using SmartSocialHubServer.Domain.Entities;
using SmartSocialHubServer.Infrastructure.Repositories.Interfaces;

namespace SmartSocialHubServer.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            // Implemente a lógica de autenticação comparando hash, etc.
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<User> RegisterAsync(User user, string password)
        {
            // Lógica para criar hash, validar e persistir o usuário
            await _userRepository.AddAsync(user);
            return user;
        }
    }
}
