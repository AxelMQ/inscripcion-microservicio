using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerAndSwaggerUI(this IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            return app;
        }

        // Ahora es una extensión de IEndpointRouteBuilder y mapea endpoints.
        public static IEndpointRouteBuilder MapCustomHealthChecks(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapHealthChecks("/health/live",
                new HealthCheckOptions { Predicate = r => r.Tags.Contains("live") });

            endpoints.MapHealthChecks("/health/ready",
                new HealthCheckOptions { Predicate = r => r.Tags.Contains("ready") });

            return endpoints;
        }
    }
}
