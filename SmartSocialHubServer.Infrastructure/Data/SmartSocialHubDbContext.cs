
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartSocialHubServer.Domain.Entities; // Certifique-se de que ApplicationUser, Post, Comment e Tenant estão definidos nesse namespace

namespace SmartSocialHubServer.Infrastructure.Data
{
    public class SmartSocialHubDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly string _tenantId;

        public SmartSocialHubDbContext(DbContextOptions<SmartSocialHubDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            // Captura o TenantId a partir do HttpContext, se disponível; caso contrário, define "defaultTenant"
            _tenantId = httpContextAccessor?.HttpContext?.Items["TenantId"]?.ToString() ?? "defaultTenant";
        }

        // DbSets para as entidades customizadas
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chama a implementação base para registrar as tabelas do Identity (AspNetUsers, AspNetRoles, etc.)
            base.OnModelCreating(modelBuilder);

            // Aplica filtros globais para isolar os dados por TenantId nas entidades customizadas
            modelBuilder.Entity<Post>().HasQueryFilter(p => p.TenantId == _tenantId);
            modelBuilder.Entity<Comment>().HasQueryFilter(c => c.TenantId == _tenantId);

            // Outras configurações podem ser aplicadas aqui conforme necessário
        }
    }
}
