using SmartSocialHubServer.Domain.Entities;

namespace SmartSocialHubServer.Domain.Factories
{
    public class SocialContentFactory : IContentFactory
    {
        public Post CreatePost()
        {
            return new Post
            {
                CreatedAt = DateTime.UtcNow
            };
        }

        public Comment CreateComment()
        {
            return new Comment
            {
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
