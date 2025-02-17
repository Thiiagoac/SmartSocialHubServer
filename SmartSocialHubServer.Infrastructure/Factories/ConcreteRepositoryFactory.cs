

using SmartSocialHubServer.Infrastructure.Data;
using SmartSocialHubServer.Infrastructure.Repositories;
using SmartSocialHubServer.Infrastructure.Repositories.Interfaces;

namespace SmartSocialHubServer.Infrastructure.Factories
{
    public class ConcreteRepositoryFactory : RepositoryFactory
    {
        public override IUserRepository CreateUserRepository(SmartSocialHubDbContext context)
        {
            return new UserRepository(context);
        }
        public override IPostRepository CreatePostRepository(SmartSocialHubDbContext context)
        {
            return new PostRepository(context);
        }
        public override ICommentRepository CreateCommentRepository(SmartSocialHubDbContext context)
        {
            return new CommentRepository(context);
        }
    }
}
