using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Infrastructure.Data;
using Npgsql;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Application.Interfaces;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("DefaultConnection")
                 ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

if (string.IsNullOrWhiteSpace(connString))
{
    throw new InvalidOperationException(
        "Missing ConnectionStrings:DefaultConnection (or env ConnectionStrings__DefaultConnection). Please configure before starting the API.");
}

// ── EF Core + Npgsql ──────────────────────────────────────────────────────────
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(connString));

// ── Registrar Repositorios ──────────────────────────────────────────────────
// Estos son cruciales para que la inyección de dependencias funcione
builder.Services.AddScoped<IAlumnoRepository, AlumnoRepository>();
builder.Services.AddScoped<ICarreraRepository, CarreraRepository>();
builder.Services.AddScoped<IDocenteRepository, DocenteRepository>();
builder.Services.AddScoped<IDiaRepository, DiaRepository>();
builder.Services.AddScoped<IGestionRepository, GestionRepository>();
builder.Services.AddScoped<IHoraRepository, HoraRepository>();
builder.Services.AddScoped<IHorarioRepository, HorarioRepository>();
builder.Services.AddScoped<IHorarioMateriaRepository, HorarioMateriaRepository>();
builder.Services.AddScoped<IInscripcionRepository, InscripcionRepository>();
builder.Services.AddScoped<IMateriaRepository, MateriaRepository>();
builder.Services.AddScoped<IMateriaPlanEstudioRepository, MateriaPlanEstudioRepository>();
builder.Services.AddScoped<IModuloRepository, ModuloRepository>();
builder.Services.AddScoped<INivelRepository, NivelRepository>();
builder.Services.AddScoped<IPlanEstudioRepository, PlanEstudioRepository>();
builder.Services.AddScoped<IPrerequisitoRepository, PrerequisitoRepository>();
builder.Services.AddScoped<IHoraDiaRepository, HoraDiaRepository>();
builder.Services.AddScoped<IHoraDiaHorarioRepository, HoraDiaHorarioRepository>();
builder.Services.AddScoped<IHorarioMateriaInscripcionRepository, HorarioMateriaInscripcionRepository>();
builder.Services.AddScoped<INotaRepository, NotaRepository>();
builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();
builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();

/* // Register Use Cases
builder.Services.AddScoped<IGetMateriasDelPlanEstudioUseCase, GetMateriasDelPlanEstudioUseCase>(); */

builder.Services.AddHealthChecks()
    .AddCheck("self", () => HealthCheckResult.Healthy(), tags: new[] { "live" })
    .AddNpgSql(connString, name: "postgres", tags: new[] { "ready" });

var app = builder.Build();

//PARA MOSTRAR O NO EN PRODUCCION
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//BORAR SI NO ESTA EN PRODUCCION
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health/live", new HealthCheckOptions { Predicate = r => r.Tags.Contains("live") });
app.MapHealthChecks("/health/ready", new HealthCheckOptions { Predicate = r => r.Tags.Contains("ready") });

app.Run();
