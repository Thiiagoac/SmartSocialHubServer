namespace SmartSocialHubServer.Domain.Entities
{
    public class Tenant
    {
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string Theme { get; set; } // Pode ser um JSON com configurações
    }
}
