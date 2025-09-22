using Api.Extensions;
using Hangfire;
using Infrastructure.Background; // 👈 necesario para UseHangfireDashboard

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddHealthChecks(builder.Configuration)
    .AddSwaggerDocumentation()
    .AddJwtAuthentication(builder.Configuration);

/* builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5239); // usa el mismo puerto que ya usas en local
}); */

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// ORDEN CLAVE
app.UseRouting();
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

// (opcional) endpoint de prueba para encolar un job rápido
app.MapGet("/test-job", () =>
{
    BackgroundJob.Enqueue(() => Console.WriteLine("¡Job ejecutado desde Hangfire!"));
    return Results.Ok("Job encolado");
});

app.Run();
