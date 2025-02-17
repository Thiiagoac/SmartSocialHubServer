using SmartSocialHubServer.Infrastructure.Data;
using SmartSocialHubServer.Infrastructure.Repositories.Interfaces;

namespace SmartSocialHubServer.Infrastructure.Factories
{
    public abstract class RepositoryFactory
    {
        public abstract IUserRepository CreateUserRepository(SmartSocialHubDbContext context);
        public abstract IPostRepository CreatePostRepository(SmartSocialHubDbContext context);
        public abstract ICommentRepository CreateCommentRepository(SmartSocialHubDbContext context);
    }
}
