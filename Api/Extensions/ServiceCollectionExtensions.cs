using Application.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Shared.Mapping;

using Hangfire;
using Hangfire.PostgreSql;

using Infrastructure.Background;
using Infrastructure.Background.Services;

namespace Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // DB
            var connString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrWhiteSpace(connString))
                throw new InvalidOperationException("Missing ConnectionStrings:DefaultConnection.");

            services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(connString).UseSnakeCaseNamingConvention());

            // Repos / UoW
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IHorarioMateriaRepository, HorarioMateriaRepository>();

            // AutoMapper
            services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfiles>(),
                       new[] { typeof(MappingProfiles).Assembly });

            // Hangfire (SOLO STORAGE; sin UseFilter aquí)
            services.AddHangfire(cfg =>
            {
                cfg.UseSimpleAssemblyNameTypeSerializer()
                   .UseRecommendedSerializerSettings()
                   .UsePostgreSqlStorage(
                       b => b.UseNpgsqlConnection(connString),
                       new PostgreSqlStorageOptions
                       {
                           PrepareSchemaIfNecessary = true,
                           QueuePollInterval = TimeSpan.FromSeconds(5)
                       });
            });

            // Manager Start/Stop & operativa
            services.AddSingleton<HangfireServerManager>();

            // Jobs/servicios
            services.AddScoped<Worker>();
            services.AddScoped<AlumnoService>();
            services.AddScoped<HorarioMateriaService>();

            return services;
        }

        public static IServiceCollection AddHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrWhiteSpace(connString))
                throw new InvalidOperationException("Missing ConnectionStrings:DefaultConnection.");

            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy(), tags: new[] { "live" })
                .AddNpgSql(connString, name: "postgres", tags: new[] { "ready" });

            return services;
        }

        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Tu API", Version = "v1" });
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
                    { new OpenApiSecurityScheme
                        { Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" } },
                      Array.Empty<string>() }
                });
            });

            return services;
        }
    }
}
