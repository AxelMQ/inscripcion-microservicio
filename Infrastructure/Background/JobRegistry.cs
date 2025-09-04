using Microsoft.Extensions.DependencyInjection;
using Application.Enums;
using Infrastructure.Background.Services;   // AlumnoService
using Shared.Contracts.Dtos.Alumno;        // AlumnoCreateDto, AlumnoUpdateDto

namespace Infrastructure.Background
{
    public record IdInput(int Id);

    public abstract record JobRoute(Type DtoType)
    {
        public abstract Task<object?> InvokeAsync(IServiceProvider sp, object? dto, CancellationToken ct);

        public static JobRoute For<TDto, TService>(Func<TService, TDto?, CancellationToken, Task<object?>> invoker)
            where TService : class
            => new RouteImpl<TDto, TService>(invoker);

        private sealed record RouteImpl<TDto, TService>(
            Func<TService, TDto?, CancellationToken, Task<object?>> Invoker) : JobRoute(typeof(TDto))
            where TService : class
        {
            public override Task<object?> InvokeAsync(IServiceProvider sp, object? dto, CancellationToken ct)
            {
                var svc = sp.GetRequiredService<TService>();
                return Invoker(svc, (TDto?)dto, ct);
            }
        }
    }

    public static class JobRegistry
    {
        private static string Key(string resource, OperationType op)
            => $"{resource.Trim().ToLowerInvariant()}.{op}";

        private static readonly Dictionary<string, JobRoute> _routes = new()
        {
            // ===================== ALUMNO =====================

            // Create: AlumnoService.CreateAsync devuelve Task<AlumnoDto> -> lo casteamos a object
            [Key("alumno", OperationType.Create)] = JobRoute.For<AlumnoCreateDto, AlumnoService>(
                async (svc, dto, ct) => (object?) await svc.CreateAsync(dto!, ct)),

            // GetAll: ya devuelve IEnumerable<AlumnoDto> -> también lo casteamos a object
            [Key("alumno", OperationType.GetAll)] = JobRoute.For<object?, AlumnoService>(
                async (svc, _, ct) => (object?) await svc.GetAllAsync(ct)),

            // GetById: tu servicio devuelve object? (found/item), ya es compatible
            [Key("alumno", OperationType.GetById)] = JobRoute.For<IdInput, AlumnoService>(
                (svc, dto, ct) => svc.GetByIdAsync(dto!.Id, ct)),

            // Update: si AlumnoUpdateDto incluye Id y tu servicio retorna object? (updated/item) o AlumnoDto
            // si retorna AlumnoDto, usa el mismo patrón de cast a object
            [Key("alumno", OperationType.Update)] = JobRoute.For<AlumnoUpdateDto, AlumnoService>(
                async (svc, dto, ct) => (object?) await svc.UpdateAsync(dto!.Id,dto, ct)),

            // Delete: tu servicio devuelve object? (deleted/razón)
            [Key("alumno", OperationType.Delete)] = JobRoute.For<IdInput, AlumnoService>(
                (svc, dto, ct) => svc.DeleteAsync(dto!.Id, ct)),
        };

        public static bool TryResolve(string resource, OperationType op, out JobRoute route)
            => _routes.TryGetValue(Key(resource, op), out route!);
    }
}
