using Microsoft.AspNetCore.Identity;
namespace SmartSocialHubServer.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string TenantId { get; set; }
    }
}
