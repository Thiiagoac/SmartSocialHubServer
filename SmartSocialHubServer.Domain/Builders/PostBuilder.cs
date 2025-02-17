using SmartSocialHubServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSocialHubServer.Domain.Builders
{
    public class PostBuilder
    {
        private Post _post = new Post();

        public PostBuilder WithContent(string content)
        {
            _post.Content = content;
            return this;
        }

        public PostBuilder WithUserId(int userId)
        {
            _post.UserId = userId;
            return this;
        }

        public PostBuilder WithTenantId(string tenantId)
        {
            _post.TenantId = tenantId;
            return this;
        }

        public Post Build()
        {
            _post.CreatedAt = DateTime.UtcNow;
            return _post;
        }
    }
}
