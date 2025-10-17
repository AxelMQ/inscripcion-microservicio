using Api.Extensions;
using Api.Middleware;
using Hangfire;
using Infrastructure.Background; // 👈 necesario para UseHangfireDashboard
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configurar Serilog
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

// Logs de inicio para debugging en desarrollo
// TODO: Agregar más info del sistema (RAM, CPU) en producción
Log.Information("🚀 Iniciando Microservicio de Gestión Académica");
Log.Information("📅 Fecha de inicio: {StartupTime}", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss UTC"));
Log.Information("🌍 Entorno: {Environment}", builder.Environment.EnvironmentName);

builder.Services.AddControllers();

builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddHealthChecks(builder.Configuration)
    .AddSwaggerDocumentation()
    .AddJwtAuthentication(builder.Configuration);

// Configurar Kestrel para escuchar en todas las interfaces
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5239); // Escucha en todas las interfaces de red
});

// Configuración de CORS dinámica usando variables de entorno
builder.Services.AddCors(options =>
{
    // Obtener configuración desde variables de entorno o appsettings
    var corsOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? 
                      builder.Configuration["CORS_ALLOWED_ORIGINS"]?.Split(',') ?? 
                      new[] { "http://localhost:3000" };
    
    var corsMethods = builder.Configuration.GetSection("Cors:AllowedMethods").Get<string[]>() ?? 
                      builder.Configuration["CORS_ALLOWED_METHODS"]?.Split(',') ?? 
                      new[] { "GET", "POST", "PUT", "DELETE", "OPTIONS" };
    
    var corsHeaders = builder.Configuration.GetSection("Cors:AllowedHeaders").Get<string[]>() ?? 
                      builder.Configuration["CORS_ALLOWED_HEADERS"]?.Split(',') ?? 
                      new[] { "Content-Type", "Authorization", "X-Requested-With" };
    
    var allowCredentials = builder.Configuration.GetValue<bool>("Cors:AllowCredentials", true);
    var preflightMaxAge = builder.Configuration.GetValue<int>("Cors:PreflightMaxAge", 600);
    
    // Política dinámica basada en configuración
    options.AddPolicy("DynamicCors", builder => 
    {
        builder.WithOrigins(corsOrigins)
               .WithMethods(corsMethods)
               .WithHeaders(corsHeaders)
               .SetPreflightMaxAge(TimeSpan.FromSeconds(preflightMaxAge));
        
        if (allowCredentials)
        {
            builder.AllowCredentials();
        }
    });
    
    // Política para desarrollo - más permisiva
    options.AddPolicy("Development",
        policy => policy
            .SetIsOriginAllowed(origin => 
            {
                // Permitir localhost y IPs locales
                return origin.StartsWith("http://localhost") || 
                       origin.StartsWith("http://127.0.0.1") ||
                       origin.StartsWith("http://10.0.2.2") ||
                       origin.StartsWith("http://192.168.") ||
                       origin.StartsWith("http://10.");
            })
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
    
    // Política para mobile apps - validación dinámica
    options.AddPolicy("MobileApp",
        policy => policy
            .SetIsOriginAllowed(origin => 
            {
                // Obtener IPs permitidas desde variables de entorno
                var allowedIPs = builder.Configuration["MOBILE_ALLOWED_IPS"]?.Split(',') ?? 
                                new[] { "192.168.", "10.", "localhost" };
                
                return allowedIPs.Any(ip => origin.StartsWith($"http://{ip}") || 
                                          origin.StartsWith($"https://{ip}"));
            })
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});


var app = builder.Build();

// Configurar manejo de excepciones
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseGlobalExceptionMiddleware();
}

// Middleware personalizado para errores de base de datos
app.UseMiddleware<DatabaseErrorMiddleware>();

app.UseHttpsRedirection();

// ORDEN CLAVE
app.UseRouting();

// Configurar CORS
var corsPolicy = Environment.GetEnvironmentVariable("CORS_POLICY") ?? 
                 builder.Configuration["CORS_POLICY"] ?? 
                 (app.Environment.IsDevelopment() ? "Development" : "DynamicCors");

// Log para debugging
Console.WriteLine($"🌐 Ambiente: {app.Environment.EnvironmentName}");
Console.WriteLine($"🔒 Política CORS: {corsPolicy}");

app.UseCors(corsPolicy);

app.UseAuthentication();
app.UseAuthorization();

// 👇 Dashboard de Hangfire (protégelo en prod)
app.UseHangfireDashboard("/hangfire");
// Si quieres protegerlo con auth/roles, usa:
// app.UseHangfireDashboard("/hangfire", new DashboardOptions {
//     Authorization = new[] { new HangfireDashboardAuthorization() } // implementa IDashboardAuthorizationFilter
// });

app.UseSwaggerAndSwaggerUI(app.Environment);


// Endpoints
app.MapControllers();
app.MapCustomHealthChecks();

// Endpoint de prueba para verificar conexión
app.MapGet("/api/health", () =>
{
    return Results.Ok(new { 
        message = "Microservicio funcionando correctamente",
        timestamp = DateTime.UtcNow,
        version = "1.0.0"
    });
});

// Endpoint para información de red (útil para mobile/web)
app.MapGet("/api/network-info", () =>
{
    var networkIP = GetLocalIPAddress();
    return Results.Ok(new { 
        message = "Información de red para desarrollo mobile/web",
        server = new {
            localhost = "http://localhost:5239",
            network = $"http://{networkIP}:5239",
            ip = networkIP
        },
        endpoints = new {
            health = "http://localhost:5239/api/health",
            swagger = "http://localhost:5239/swagger",
            hangfire = "http://localhost:5239/hangfire",
            network_health = $"http://{networkIP}:5239/api/health"
        },
        timestamp = DateTime.UtcNow
    });
});

// Endpoint alternativo más simple
app.MapGet("/api/ping", () =>
{
    return Results.Ok(new { 
        message = "Pong! Servidor funcionando",
        timestamp = DateTime.UtcNow
    });
});

// Endpoint para probar concurrencia (solo para desarrollo)
app.MapGet("/api/test/concurrencia", async (IUnitOfWork uow) =>
{
    var hmRepo = uow.HorarioMateriaRepository;
    var horarios = await hmRepo.Query()
        .Where(hm => hm.CuposDisponibles > 0)
        .Take(3)
        .ToListAsync();
    
    return Results.Ok(new {
        message = "Horarios disponibles para prueba de concurrencia",
        horarios = horarios.Select(h => new {
            h.Id,
            h.CuposDisponibles,
            h.CuposTotal,
            PorcentajeOcupacion = (double)(h.CuposTotal - h.CuposDisponibles) / h.CuposTotal * 100
        })
    });
});

// Endpoint para obtener errores recientes de jobs
app.MapGet("/api/jobs/errores", async (IUnitOfWork uow) =>
{
    var jobRepo = uow.GetRepository<Domain.Entities.JobResult>();
    var errores = await jobRepo.Query()
        .Where(j => j.Status == Domain.Entities.JobStatus.Failed)
        .OrderByDescending(j => j.CreatedUtc)
        .Take(10)
        .ToListAsync();
    
    return Results.Ok(new {
        message = "Últimos 10 errores de jobs",
        errores = errores.Select(j => new {
            j.Id,
            j.IdempotencyKey,
            j.Resource,
            j.Operation,
            j.Error,
            j.CreatedUtc,
            j.FinishedUtc,
            TiempoProcesamiento = j.FinishedUtc.HasValue ? 
                (double?)(j.FinishedUtc.Value - j.CreatedUtc).TotalMilliseconds : null
        })
    });
});

// (opcional) endpoint de prueba para encolar un job rápido
app.MapGet("/test-job", () =>
{
    BackgroundJob.Enqueue(() => Console.WriteLine("¡Job ejecutado desde Hangfire!"));
    return Results.Ok("Job encolado");
});

// Obtener IP de la red local
var networkIP = GetLocalIPAddress();

// Logging de configuración completada
Log.Information("✅ Configuración de la aplicación completada");
Log.Information("🌐 Servidor iniciando en: http://localhost:5239");
Log.Information("📱 Para Mobile/Web usar: http://{NetworkIP}:5239", networkIP);
Log.Information("📊 Dashboard Hangfire: http://localhost:5239/hangfire");
Log.Information("📚 Documentación Swagger: http://localhost:5239/swagger");
Log.Information("❤️ Health Check: http://localhost:5239/api/health");

app.Run();

// Función para obtener la IP de la red local
// NOTA: Esto es útil para desarrollo mobile/web en la misma red
// FIXME: Verificar si funciona en redes corporativas con VPN
static string GetLocalIPAddress()
{
    try
    {
        var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        return "localhost";
    }
    catch
    {
        // Si falla, usar localhost como fallback
        return "localhost";
    }
}
