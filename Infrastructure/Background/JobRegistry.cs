using System.Reflection;
using Application.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Background
{
    // Wrappers genéricos para operaciones con Id
    public readonly record struct IdInput<T>(T Id);
    public readonly record struct UpdateInput<TId, TUpdate>(TId Id, TUpdate Dto);


    // Contrato de ruta
    public abstract record JobRoute(Type DtoType)
    {
        public abstract Task<object?> InvokeAsync(IServiceProvider sp, object? dto, CancellationToken ct);

        // Helper genérico (lo usamos cuando sí conocemos TService en compile-time)
        public static JobRoute For<TDto, TService>(
            Func<TService, TDto?, CancellationToken, Task<object?>> invoker)
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

    // Ruta dinámica basada en reflexión (para el escaneo automático)
    // ANTES
    // internal sealed class DynamicRoute : JobRoute

    // DESPUÉS
    internal sealed record DynamicRoute : JobRoute
    {
        private readonly Type _serviceType;
        private readonly Func<object, object?[], Task<object?>> _invokeAsync;

        public DynamicRoute(Type dtoType, Type serviceType, Func<object, object?[], Task<object?>> invokeAsync)
            : base(dtoType)
        {
            _serviceType = serviceType;
            _invokeAsync = invokeAsync;
        }

        public override Task<object?> InvokeAsync(IServiceProvider sp, object? dto, CancellationToken ct)
        {
            var svc = sp.GetRequiredService(_serviceType);
            var args = dto is null ? new object?[] { null, ct } : new object?[] { dto, ct };
            return _invokeAsync(svc, args);
        }
    }


    public static class JobRegistry
    {
        private static IReadOnlyDictionary<string, JobRoute> _routes = new Dictionary<string, JobRoute>();

        private static string Key(string resource, OperationType op)
            => $"{resource.Trim().ToLowerInvariant()}.{op}";

        // 👇 Se ejecuta automáticamente la primera vez que alguien use JobRegistry
        static JobRegistry()
        {
            // Escanea el ensamblado donde viven tus *Service (ej.: AlumnoService)
            InitializeFromAssembly(typeof(Services.AlumnoService).Assembly);
            // También escanea el ensamblado de Infrastructure para InscripcionService
            InitializeFromAssembly(typeof(Infrastructure.Background.Services.InscripcionService).Assembly);
            
            // Registro manual de InscripcionService para asegurar que esté disponible
            RegisterInscripcionService();
        }

        private static void RegisterInscripcionService()
        {
            var dict = new Dictionary<string, JobRoute>(_routes);
            
            // Registro manual de InscripcionService
            var inscripcionServiceType = typeof(Infrastructure.Background.Services.InscripcionService);
            var createMethod = inscripcionServiceType.GetMethod("CreateAsync");
            
            if (createMethod != null)
            {
                var dtoType = createMethod.GetParameters()[0].ParameterType;
                
                dict["inscripcion.create"] = new DynamicRoute(
                    dtoType: dtoType,
                    serviceType: inscripcionServiceType,
                    invokeAsync: (svc, args) => 
                    {
                        var task = (Task)(createMethod.Invoke(svc, args) ?? throw new InvalidOperationException("Invoke devolvió null"));
                        return task.ContinueWith(t => t.GetType().GetProperty("Result")?.GetValue(t));
                    }
                );
            }
            
            _routes = dict;
        }

        public static void InitializeFromAssembly(Assembly asm)
        {
            var dict = new Dictionary<string, JobRoute>(_routes);

            foreach (var svcType in asm.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service")))
            {
                var resource = svcType.Name.Replace("Service", "").ToLowerInvariant();

                var mCreate = svcType.GetMethod("CreateAsync");
                var mAll = svcType.GetMethod("GetAllAsync");
                var mById = svcType.GetMethod("GetByIdAsync");
                var mUpd = svcType.GetMethod("UpdateAsync");
                var mDel = svcType.GetMethod("DeleteAsync");

                if (mCreate is null || mAll is null || mById is null || mUpd is null || mDel is null)
                    continue;

                // ===== Detectar tipos reales =====
                var idType = mById.GetParameters()[0].ParameterType;          // ej: int o Guid
                var createType = mCreate.GetParameters()[0].ParameterType;        // ej: AlumnoCreateDto
                var updateType = mUpd.GetParameters()[1].ParameterType;           // ej: AlumnoUpdateDto

                // Construir wrappers genéricos cerrados
                var idInputType = typeof(IdInput<>).MakeGenericType(idType);
                var updateInputType = typeof(UpdateInput<,>).MakeGenericType(idType, updateType);

                // Helper para invocar Task / Task<T>
                static async Task<object?> Call(MethodInfo mi, object svc, params object?[] args)
                {
                    var task = (Task)(mi.Invoke(svc, args) ?? throw new InvalidOperationException("Invoke devolvió null"));
                    await task.ConfigureAwait(false);
                    return task.GetType().GetProperty("Result")?.GetValue(task);
                }

                // ===== Create(dto, ct)
                dict[Key(resource, OperationType.Create)] = new DynamicRoute(
                    dtoType: createType,
                    serviceType: svcType,
                    invokeAsync: (svc, args) => Call(mCreate, svc, args[0]!, (CancellationToken)args[1]!)
                );

                // ===== GetAll(ct) — no requiere body
                dict[Key(resource, OperationType.GetAll)] = new DynamicRoute(
                    dtoType: typeof(object),
                    serviceType: svcType,
                    invokeAsync: (svc, args) => Call(mAll, svc, (CancellationToken)args[1]!)
                );

                // ===== GetById(IdInput<TId>, ct)
                dict[Key(resource, OperationType.GetById)] = new DynamicRoute(
                    dtoType: idInputType,
                    serviceType: svcType,
                    invokeAsync: (svc, args) =>
                    {
                        var dto = args[0]!;
                        var id = idInputType.GetProperty("Id")!.GetValue(dto);
                        return Call(mById, svc, id!, (CancellationToken)args[1]!);
                    }
                );

                // ===== Update(UpdateInput<TId, TUpdate>, ct)
                dict[Key(resource, OperationType.Update)] = new DynamicRoute(
                    dtoType: updateInputType,
                    serviceType: svcType,
                    invokeAsync: (svc, args) =>
                    {
                        var dto = args[0]!;
                        var id = updateInputType.GetProperty("Id")!.GetValue(dto);
                        var body = updateInputType.GetProperty("Dto")!.GetValue(dto); // <- ahora es AlumnoUpdateDto real
                        return Call(mUpd, svc, id!, body!, (CancellationToken)args[1]!);
                    }
                );

                // ===== Delete(IdInput<TId>, ct)
                dict[Key(resource, OperationType.Delete)] = new DynamicRoute(
                    dtoType: idInputType,
                    serviceType: svcType,
                    invokeAsync: (svc, args) =>
                    {
                        var dto = args[0]!;
                        var id = idInputType.GetProperty("Id")!.GetValue(dto);
                        return Call(mDel, svc, id!, (CancellationToken)args[1]!);
                    }
                );
            }

            _routes = dict;
        }
        public static bool TryResolve(string resource, OperationType op, out JobRoute route)
            => _routes.TryGetValue(Key(resource, op), out route!);

        // (Opcional) para depurar
        public static IEnumerable<string> DebugKeys() => _routes.Keys;
    }
}
