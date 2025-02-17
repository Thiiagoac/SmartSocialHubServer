using SmartSocialHubServer.Domain.Entities;

namespace SmartSocialHubServer.Domain.Factories
{
    public interface IContentFactory
    {
        Post CreatePost();
        Comment CreateComment();
    }
}
