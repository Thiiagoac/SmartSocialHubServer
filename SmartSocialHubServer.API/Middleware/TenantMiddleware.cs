namespace SmartSocialHubServer.API.Middleware
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var tenantId = context.Request.Headers["X-Tenant-ID"].FirstOrDefault();
            if (string.IsNullOrEmpty(tenantId))
            {
                tenantId = "defaultTenant";
            }
            context.Items["TenantId"] = tenantId;
            await _next(context);
        }
    }
}
