# 📊 Sistema de Logging con Serilog

## 🎯 Descripción General

Este microservicio utiliza **Serilog** como sistema de logging estructurado, similar a Laravel Log en PHP. Los logs permiten monitorear, depurar y auditar todas las operaciones del sistema.

## 📁 Ubicación de los Logs

Los archivos de log se guardan en:
```
Api/logs/microservicio-YYYYMMDD.log
```

### Ejemplo:
- `microservicio-20251017.log` (log del 17 de octubre de 2025)

## 🔧 Configuración

### Configuración en `appsettings.Development.json`

```json
"Serilog": {
  "Using": ["Serilog.Sinks.Console", "Serilog.Sinks.File"],
  "MinimumLevel": {
    "Default": "Information",
    "Override": {
      "Microsoft": "Warning",
      "System": "Warning",
      "Microsoft.EntityFrameworkCore": "Information"
    }
  },
  "WriteTo": [
    {
      "Name": "Console",
      "Args": {
        "outputTemplate": "[{Timestamp:HH:mm:ss} {Level:u3}] {SourceContext}: {Message:lj}{NewLine}{Exception}"
      }
    },
    {
      "Name": "File",
      "Args": {
        "path": "logs/microservicio-.log",
        "rollingInterval": "Day",
        "retainedFileCountLimit": 7,
        "outputTemplate": "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} {Level:u3}] {SourceContext}: {Message:lj}{NewLine}{Exception}"
      }
    }
  ],
  "Enrich": ["FromLogContext", "WithMachineName", "WithThreadId"]
}
```

## 📝 Niveles de Log

| Nivel | Emoji | Descripción | Uso |
|-------|-------|-------------|-----|
| **Verbose** | 🔍 | Información muy detallada | Debugging profundo |
| **Debug** | 🐛 | Información de depuración | Desarrollo |
| **Information** | ℹ️ | Información general | Operaciones normales |
| **Warning** | ⚠️ | Advertencias | Situaciones no ideales |
| **Error** | ❌ | Errores | Fallos que no detienen la app |
| **Fatal** | 💥 | Errores fatales | Fallos críticos |

## 🚀 Ejemplos de Uso

### Logging Simple
```csharp
using Serilog;

Log.Information("Usuario {UserId} inició sesión", userId);
Log.Warning("Intentos de login fallidos: {Attempts}", attempts);
Log.Error(exception, "Error al procesar pago para {OrderId}", orderId);
```

### Logging Estructurado (con propiedades)
```csharp
Log.Information("🚀 Iniciando proceso de inscripción para AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}", 
    dto.AlumnoId, dto.HorarioMateriaId);
```

### Logging con Excepciones
```csharp
try
{
    // código que puede fallar
}
catch (Exception ex)
{
    Log.Error(ex, "💥 Error inesperado durante la inscripción para AlumnoId: {AlumnoId}", alumnoId);
    throw;
}
```

## 📊 Logs en el Proceso de Inscripción

El servicio de inscripciones incluye logging detallado:

### Inicio del Proceso
```
🚀 Iniciando proceso de inscripción para AlumnoId: 123, HorarioMateriaId: 456
```

### Validación de Cupos
```
📚 HorarioMateria encontrado - Cupos totales: 30, Disponibles: 15
```

### Sin Cupos Disponibles
```
🚫 No hay cupos disponibles - Cupos totales: 30, Disponibles: 0
```

### Inscripción Exitosa
```
✅ Creando inscripción exitosa para AlumnoId: 123
🎉 Inscripción completada exitosamente - InscripcionId: 789, AlumnoId: 123
```

### Error
```
💥 Error inesperado durante la inscripción para AlumnoId: 123, HorarioMateriaId: 456
System.Exception: Database connection timeout
   at Infrastructure.Background.Services.InscripcionService.CreateAsync(...)
```

## 🔍 Cómo Ver los Logs

### En Consola
Los logs se muestran en tiempo real en la consola cuando ejecutas:
```bash
dotnet run --project Api
```

### En Archivo
Los logs se guardan automáticamente en:
```
Api/logs/microservicio-20251017.log
```

Puedes verlos con:
```bash
# Ver todo el archivo
cat Api/logs/microservicio-20251017.log

# Ver las últimas líneas (en PowerShell)
Get-Content Api/logs/microservicio-20251017.log -Tail 50

# Ver en tiempo real (seguir el archivo)
Get-Content Api/logs/microservicio-20251017.log -Wait
```

## 📌 Retención de Logs

- **Retención**: 7 días (configurable en `retainedFileCountLimit`)
- **Rotación**: Diaria (un archivo nuevo por día)
- **Formato de nombre**: `microservicio-YYYYMMDD.log`

## 🎨 Formato de Logs

### En Consola
```
[09:59:04 INF] Api.Program: 🌐 Ambiente: Development
[09:59:04 INF] Api.Program: 🔒 Política CORS: Development
```

### En Archivo
```
[2025-10-17 09:59:04.293 -04:00 INF] Hangfire.PostgreSql.PostgreSqlStorage: Start installing Hangfire SQL objects...
[2025-10-17 09:59:04.596 -04:00 INF] Hangfire.PostgreSql.PostgreSqlStorage: Hangfire SQL objects installed.
```

## 🛠️ Agregar Logging a Nuevos Servicios

### 1. Agregar using
```csharp
using Serilog;
```

### 2. Agregar logs en métodos críticos
```csharp
public async Task<Result> ProcessOrder(int orderId)
{
    Log.Information("📦 Procesando orden {OrderId}", orderId);
    
    try
    {
        // lógica de negocio
        
        Log.Information("✅ Orden {OrderId} procesada exitosamente", orderId);
        return Result.Success();
    }
    catch (Exception ex)
    {
        Log.Error(ex, "❌ Error procesando orden {OrderId}", orderId);
        throw;
    }
}
```

## 🔧 Configuración Avanzada

### Cambiar Nivel de Log
En `appsettings.json`:
```json
"Serilog": {
  "MinimumLevel": {
    "Default": "Debug",  // Cambiar a Debug para más detalle
    "Override": {
      "Microsoft.EntityFrameworkCore": "Warning"  // Reducir logs de EF Core
    }
  }
}
```

### Filtrar por Namespace
```json
"Override": {
  "Infrastructure.Background": "Debug",
  "Microsoft": "Warning",
  "System": "Error"
}
```

## 📚 Recursos Adicionales

- [Documentación de Serilog](https://serilog.net/)
- [Serilog Best Practices](https://github.com/serilog/serilog/wiki/Structured-Data)
- [ASP.NET Core Logging](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/)

## 💡 Tips

1. **Usa propiedades estructuradas**: En lugar de `Log.Information($"Usuario {userId}")`, usa `Log.Information("Usuario {UserId}", userId)`
2. **No logees información sensible**: Evita contraseñas, tokens, datos personales
3. **Usa niveles apropiados**: Information para operaciones normales, Warning para situaciones anómalas
4. **Agrega contexto**: Incluye IDs relevantes (OrderId, UserId, etc.)
5. **Logs con emojis**: Hacen más fácil identificar tipos de operaciones visualmente

## 🚨 Importante

- Los archivos de log **no deben subirse a Git** (ya están en `.gitignore`)
- Los logs pueden contener información sensible, protégelos adecuadamente
- En producción, considera usar servicios externos como Seq, Elasticsearch, o Application Insights

