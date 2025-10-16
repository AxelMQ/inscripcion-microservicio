# 🎓 Sistema de Inscripción Universitaria - Microservicio Asíncrono

## 📋 Descripción del Proyecto

Sistema de gestión académica que implementa un **microservicio de inscripciones asíncronas** con control de concurrencia, manejo de cupos limitados y procesamiento en background usando **Hangfire**.

### 🎯 Características Principales

- ✅ **Procesamiento Asíncrono**: Inscripciones procesadas en background
- ✅ **Control de Concurrencia**: Manejo seguro de cupos limitados
- ✅ **Idempotencia**: Prevención de duplicados con `IdempotencyKey`
- ✅ **Estados en Tiempo Real**: Tracking de Pending → Processing → Completed/Failed
- ✅ **Retry Logic**: Reintentos automáticos en conflictos de concurrencia
- ✅ **APIs Duales**: Endpoints síncronos y asíncronos

---

## 🏗️ Arquitectura del Sistema

### 📁 Estructura del Proyecto

```
📦 inscripcion-microservicio/
├── 🚀 Api/                          # Capa de presentación
│   ├── Controllers/
│   │   ├── Async/                   # Controladores asíncronos
│   │   │   ├── InscripcionAsyncController.cs
│   │   │   ├── AlumnoAsyncController.cs
│   │   │   └── ...
│   │   └── Sync/                    # Controladores síncronos
│   │       ├── InscripcionController.cs
│   │       ├── AlumnoController.cs
│   │       └── ...
│   ├── Middleware/                  # Middleware personalizado
│   └── Extensions/                  # Extensiones de configuración
├── 🏛️ Domain/                       # Entidades y reglas de negocio
│   ├── Entities/                    # Entidades del dominio
│   ├── Enums/                       # Enumeraciones
│   └── Exceptions/                  # Excepciones de negocio
├── 🔧 Application/                  # Casos de uso e interfaces
│   ├── Interfaces/                  # Contratos de repositorios
│   └── Messages/                    # Mensajes para jobs
├── 🏗️ Infrastructure/               # Implementaciones y persistencia
│   ├── Background/                  # Sistema de procesamiento asíncrono
│   │   ├── Worker.cs               # Worker principal de Hangfire
│   │   ├── JobRegistry.cs          # Registro de servicios
│   │   └── Services/               # Servicios de background
│   ├── Data/                       # Contexto de base de datos
│   └── Repositories/               # Implementaciones de repositorios
└── 📦 Shared/                       # DTOs y contratos compartidos
    └── Contracts/Dtos/             # Data Transfer Objects
```

---

## 🚀 Tecnologías Utilizadas

| Tecnología | Versión | Propósito |
|------------|---------|-----------|
| **.NET** | 8.0 | Framework principal |
| **Entity Framework Core** | 8.0 | ORM y migraciones |
| **Hangfire** | 1.8+ | Procesamiento asíncrono |
| **SQL Server** | - | Base de datos |
| **AutoMapper** | 12.0+ | Mapeo de objetos |
| **Swagger/OpenAPI** | - | Documentación de API |

---

## 🔄 Flujo de Inscripción Asíncrona

### 1. **Solicitud de Inscripción**
```http
POST /api/async/inscripciones
{
  "alumnoId": 1,
  "horarioMateriaId": 5
}
```

### 2. **Procesamiento en Background**
- ✅ Job encolado en Hangfire
- ✅ `IdempotencyKey` generado
- ✅ Estado: `Pending`

### 3. **Validación y Procesamiento**
- ✅ Verificación de cupos disponibles
- ✅ Control de concurrencia con retry logic
- ✅ Decremento atómico de cupos
- ✅ Creación de inscripción

### 4. **Estados del Job**
```
Pending → Processing → Completed/Failed
```

---

## 🛠️ Configuración y Ejecución

### 📋 Prerrequisitos
- .NET 8.0 SDK
- SQL Server (LocalDB o Express)
- Visual Studio 2022 o VS Code

### 🚀 Ejecutar el Proyecto

```bash
# Clonar el repositorio
git clone git@github.com:AxelMQ/inscripcion-microservicio.git
cd inscripcion-microservicio

# Restaurar dependencias
dotnet restore

# Aplicar migraciones
dotnet ef database update --project Infrastructure --startup-project Api

# Ejecutar la aplicación
dotnet run --project Api
```

### 🌐 URLs Importantes
- **API**: `https://localhost:7000`
- **Swagger**: `https://localhost:7000/swagger`
- **Hangfire Dashboard**: `https://localhost:7000/hangfire`

---

## 📊 Endpoints Principales

### 🔄 **Asíncronos** (Procesamiento en Background)
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| `POST` | `/api/async/inscripciones` | Crear inscripción asíncrona |
| `GET` | `/api/async/jobs/{id}` | Estado del job |
| `GET` | `/api/async/jobs` | Listar todos los jobs |

### ⚡ **Síncronos** (Respuesta Inmediata)
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| `GET` | `/api/sync/inscripciones` | Listar inscripciones |
| `GET` | `/api/sync/horarios-materia` | Listar horarios disponibles |
| `POST` | `/api/sync/inscripciones` | Inscripción inmediata |

---

## 🎯 Casos de Uso Implementados

### ✅ **Inscripción con Cupos Limitados**
- Control de concurrencia para evitar sobreventa
- Retry logic para conflictos de concurrencia
- Validación de disponibilidad en tiempo real

### ✅ **Procesamiento Asíncrono**
- Jobs encolados en Hangfire
- Estados trackeables: Pending → Processing → Completed/Failed
- Idempotencia para prevenir duplicados

### ✅ **Manejo de Errores**
- Excepciones específicas de negocio
- Logging detallado de errores
- Rollback automático en fallos

---

## 🧪 Testing y Validación

### 📈 **Pruebas de Carga**
- Scripts JMeter para 50-100 usuarios concurrentes
- Validación de control de concurrencia
- Métricas de latencia y throughput

### 🔍 **Validaciones de Negocio**
- ✅ Cupos disponibles
- ✅ Conflictos de horario
- ✅ Prerequisitos de materias
- ✅ Estados de inscripción

---

## 📚 Documentación Adicional

- [Manejo de Excepciones](Api/Documentation/ExceptionHandling.md)
- [Configuración de Hangfire](Infrastructure/Background/)
- [Entidades del Dominio](Domain/Entities/)

---

## 👥 Contribución

Este proyecto forma parte del curso **Tópicos 2025 - Semestre 2** y está diseñado para demostrar:

- **Arquitectura de Microservicios**
- **Procesamiento Asíncrono**
- **Control de Concurrencia**
- **Patrones de Diseño**

---

## 📅 Cronograma del Proyecto

- **16 Octubre 2025**: Presentación Intermedia (25%)
- **30 Octubre 2025**: Presentación Final (25%)
- **Tareas Semanales**: 50% de la nota

---

## 🏆 Características Destacadas

### 🚀 **Performance**
- Procesamiento asíncrono no bloqueante
- Control de concurrencia optimizado
- Retry logic inteligente

### 🔒 **Confiabilidad**
- Idempotencia garantizada
- Manejo robusto de errores
- Estados consistentes

### 📱 **Escalabilidad**
- APIs para Web y Mobile
- Procesamiento distribuido
- Monitoreo en tiempo real

---

*Desarrollado con ❤️ para el curso de Tópicos 2025*