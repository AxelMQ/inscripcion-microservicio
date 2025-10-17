using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerAndSwaggerUI(this IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                // Swagger UI en la ruta estándar /swagger
                c.RoutePrefix = "swagger";

                // SOLO los docs que registraste
                c.SwaggerEndpoint("/swagger/sync/swagger.json", "API Síncronos v1");
                c.SwaggerEndpoint("/swagger/async/swagger.json", "API Asíncronos v1");

                c.DocumentTitle = "Docs – Sync/Async"; // para confirmar visualmente
                c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                c.DefaultModelsExpandDepth(-1);
            });

            return app;
        }
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
