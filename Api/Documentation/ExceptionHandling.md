# Sistema de Manejo de Excepciones Personalizado

## Resumen

Este sistema implementa un manejo robusto y estructurado de excepciones con logging detallado para la API de gestión académica.

## Componentes del Sistema

### 1. Excepciones Personalizadas del Dominio

#### `HorarioMateriaNotFoundException`
- **Propósito**: Se lanza cuando no se encuentra un horario de materia específico
- **Código HTTP**: 404 Not Found
- **Uso**: `throw new HorarioMateriaNotFoundException(id);`

#### `AlumnoNotFoundException`
- **Propósito**: Se lanza cuando no se encuentra un alumno específico
- **Código HTTP**: 404 Not Found
- **Uso**: `throw new AlumnoNotFoundException(id);`

#### `InscripcionNotFoundException`
- **Propósito**: Se lanza cuando no se encuentra una inscripción específica
- **Código HTTP**: 404 Not Found
- **Uso**: `throw new InscripcionNotFoundException(id);`

#### `NoSeatsAvailableException`
- **Propósito**: Se lanza cuando no hay cupos disponibles para una materia
- **Código HTTP**: 409 Conflict
- **Uso**: `throw new NoSeatsAvailableException("Mensaje descriptivo");`

#### `ValidationException`
- **Propósito**: Se lanza cuando hay errores de validación en los datos
- **Código HTTP**: 400 Bad Request
- **Uso**: 
```csharp
var errors = new Dictionary<string, string[]>
{
    ["Campo"] = new[] { "Error de validación" }
};
throw new ValidationException(errors);
```

#### `BusinessRuleException`
- **Propósito**: Se lanza cuando se viola una regla de negocio
- **Código HTTP**: 422 Unprocessable Entity
- **Uso**: `throw new BusinessRuleException("NombreRegla", "Mensaje descriptivo");`

### 2. Middleware Global de Excepciones

El `GlobalExceptionMiddleware` captura automáticamente todas las excepciones no manejadas y:

1. **Logging Estructurado**: Registra la excepción con contexto del usuario
2. **Respuesta Consistente**: Devuelve respuestas JSON estructuradas
3. **Códigos HTTP Apropiados**: Mapea excepciones a códigos HTTP correctos

### 3. Servicio de Logging de Excepciones

El `ExceptionLoggingService` proporciona logging estructurado con:

- **Contexto del Usuario**: Identifica quién causó la excepción
- **Datos Adicionales**: Permite agregar contexto específico
- **Categorización**: Diferentes niveles de logging según el tipo de excepción

## Flujo de Estados de Inscripción

### Estados Disponibles
- **Pending**: Inscripción pendiente de procesamiento
- **Processing**: Inscripción siendo procesada
- **Completed**: Inscripción confirmada exitosamente
- **Failed**: Inscripción rechazada o fallida

### Transiciones de Estado
```
Pending → Processing → Completed
Pending → Processing → Failed
```

## Ejemplos de Uso

### En Controladores

```csharp
[HttpGet("{id}")]
public async Task<IActionResult> GetById(int id)
{
    var entity = await _repository.GetByIdAsync(id);
    if (entity == null)
        throw new EntityNotFoundException(id);
    
    return Ok(entity);
}
```

### En Servicios de Negocio

```csharp
public async Task ConfirmarInscripcion(int inscripcionId)
{
    var inscripcion = await _repository.GetByIdAsync(inscripcionId);
    if (inscripcion == null)
        throw new InscripcionNotFoundException(inscripcionId);
    
    if (inscripcion.Estado != RequestState.Pending)
        throw new BusinessRuleException("EstadoInvalido", 
            "Solo se pueden confirmar inscripciones pendientes");
    
    // Lógica de negocio...
}
```

## Respuestas de Error Estructuradas

### Formato de Respuesta
```json
{
  "statusCode": 404,
  "message": "No se encontró el horario de materia con ID: 123",
  "details": "HorarioMateria con ID 123 no encontrado",
  "type": "HorarioMateriaNotFound",
  "timestamp": "2024-01-15T10:30:00Z"
}
```

### Respuesta de Validación
```json
{
  "statusCode": 400,
  "message": "Se han producido uno o más errores de validación.",
  "details": "Errores de validación en los datos enviados",
  "type": "ValidationError",
  "validationErrors": {
    "AlumnoId": ["El ID del alumno es requerido"],
    "HorarioMateriaIds": ["Debe seleccionar al menos un horario de materia"]
  },
  "timestamp": "2024-01-15T10:30:00Z"
}
```

## Configuración

### Program.cs
```csharp
// En desarrollo: usar página de excepciones detallada
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // En producción: usar middleware personalizado
    app.UseGlobalExceptionMiddleware();
}
```

### ServiceCollectionExtensions.cs
```csharp
// Registrar servicios de logging
services.AddScoped<IExceptionLoggingService, ExceptionLoggingService>();
```

## Beneficios del Sistema

1. **Consistencia**: Todas las excepciones se manejan de manera uniforme
2. **Trazabilidad**: Logging estructurado para debugging y monitoreo
3. **Claridad**: Mensajes de error claros para desarrolladores y usuarios
4. **Mantenibilidad**: Fácil agregar nuevos tipos de excepciones
5. **Seguridad**: No expone información sensible en producción

## Mejores Prácticas

1. **Usar excepciones específicas** en lugar de excepciones genéricas
2. **Incluir contexto relevante** en los mensajes de error
3. **Logging apropiado** según el nivel de criticidad
4. **Validación temprana** para evitar excepciones innecesarias
5. **Documentación clara** de cuándo usar cada tipo de excepción

