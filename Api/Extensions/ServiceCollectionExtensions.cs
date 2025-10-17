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
using Application.Data.Entities;
using Api.Services;

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
                opt.UseNpgsql(connString));

            // Repos / UoW
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IJobResultRepository, JobResultRepository>();
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
            services.AddSingleton<HotHangfireServerManager>();
            // Jobs/servicios
            services.AddScoped<Worker>();
            services.AddScoped<AlumnoService>();
            services.AddScoped<HorarioMateriaService>();
            services.AddScoped<MateriaService>();
            services.AddScoped<DocenteService>();
            services.AddScoped<CarreraService>();
            services.AddScoped<InscripcionService>();

            // Servicios de logging de excepciones
            services.AddScoped<IExceptionLoggingService, ExceptionLoggingService>();

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
                // === dos definiciones ===
                options.SwaggerDoc("sync", new OpenApiInfo { Title = "API Síncronos", Version = "v1" });
                options.SwaggerDoc("async", new OpenApiInfo { Title = "API Asíncronos", Version = "v1" });

                // Incluir acciones solo en el doc que coincida con su GroupName
                options.DocInclusionPredicate((docName, apiDesc) =>
                    string.Equals(apiDesc.GroupName, docName, StringComparison.OrdinalIgnoreCase));

                // === seguridad JWT (igual que ya tenías) ===
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT: Authorization: Bearer {token}",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                {
                    new OpenApiSecurityScheme {
                        Reference = new OpenApiReference {
                            Type = ReferenceType.SecurityScheme, Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
                });
            });

            return services;
        }
    }
}
