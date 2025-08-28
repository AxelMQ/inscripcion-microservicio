// Extensions/ServiceCollectionExtensions.cs

using Application.Interfaces;
using Application.Messages;
using Application.Services;
using Application.Strategies;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading.Channels;
using Microsoft.OpenApi.Models; // <-- Added this using directive


namespace Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // ── EF Core + Npgsql ──────────────────────────────────────────────────────────
            var connString = configuration.GetConnectionString("DefaultConnection")
                           ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

            if (string.IsNullOrWhiteSpace(connString))
            {
                throw new InvalidOperationException(
                    "Missing ConnectionStrings:DefaultConnection. Please configure before starting the API.");
            }

            services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(connString)
       .UseSnakeCaseNamingConvention());

            // ── Registrar Repositorios ──────────────────────────────────────────────────
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // ── CONFIGURACION DEL SISTEMA ASINCRONO ───────────────────────────────────────
            services.AddSingleton(Channel.CreateUnbounded<RequestMessage>());
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddHostedService<RequestProcessorService>();
            services.AddSingleton<RequestStatusTracker>();

            // ── ESTRATEGIAS PARA LOS REPOSITORIOS ───────────────────────────────────────
            //services.AddSingleton<IRequestProcessingStrategy, StudentProcessingStrategy>();
            services.AddSingleton<IRequestProcessingStrategy, MateriaProcessingStrategy>();

            return services;
        }

        public static IServiceCollection AddHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("DefaultConnection")
                           ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

            if (string.IsNullOrWhiteSpace(connString))
            {
                throw new InvalidOperationException(
                    "Missing ConnectionStrings:DefaultConnection. Please configure before starting the API.");
            }

            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy(), tags: new[] { "live" })
                .AddNpgSql(connString!, name: "postgres", tags: new[] { "ready" });

            return services;
        }

        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Tu API", Version = "v1" });

                // Esto es lo que necesitas agregar para configurar JWT en Swagger
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
            return services;
        }
    }
}