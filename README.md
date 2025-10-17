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
- ✅ **Logging Estructurado**: Sistema de logs profesional con Serilog
- ✅ **CORS Dinámico**: Configuración flexible para desarrollo mobile/web
- ✅ **Detección de Red**: IP automática para desarrollo local

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
| **SQL Postgress** | - | Base de datos |
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
- PostgreSQL (Local o Docker)
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
- **API**: `http://localhost:5239`
- **Swagger**: `http://localhost:5239/swagger`
- **Hangfire Dashboard**: `http://localhost:5239/hangfire`
- **Health Check**: `http://localhost:5239/api/health`

---

## 🔒 Configuración de CORS

### 📱 **Para Desarrollo Mobile**

El sistema incluye configuración avanzada de CORS para soporte completo de aplicaciones móviles:

#### **Configuración Automática por Ambiente**
- **Development**: Política permisiva para desarrollo local
- **Staging**: Configuración intermedia para testing
- **Production**: Configuración restrictiva y segura

#### **Variables de Entorno Disponibles**
```bash
# Política CORS a usar
CORS_POLICY=Development|DynamicCors|MobileApp

# Orígenes permitidos (separados por coma)
CORS_ALLOWED_ORIGINS=http://localhost:3000,http://192.168.0.15:3000,https://tuapp.com

# IPs permitidas para mobile apps
MOBILE_ALLOWED_IPS=192.168.,10.,localhost
```

#### **Perfiles de Configuración**
- **Development**: Permite localhost e IPs locales
- **MobileApp**: Validación dinámica para apps móviles
- **DynamicCors**: Configuración desde variables de entorno

### 🚀 **Ejecutar con Configuración Mobile**

```powershell
# Para desarrollo mobile
$env:CORS_POLICY="MobileApp"
$env:MOBILE_ALLOWED_IPS="192.168.,10.,localhost"
dotnet run --project Api
```

### 📱 **Soporte para Flutter/React Native**
- ✅ **IPs de red local** (192.168.x.x, 10.x.x.x)
- ✅ **Localhost** para desarrollo
- ✅ **Cualquier método HTTP** (GET, POST, PUT, DELETE)
- ✅ **Headers personalizados** (Content-Type, Authorization)
- ✅ **Credentials** para autenticación

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

### ✅ **Sistema de Logging**
- Logging estructurado con Serilog
- Logs automáticos en consola y archivos
- Rotación diaria de logs (7 días de retención)
- Logging de operaciones críticas con emojis
- Códigos HTTP integrados en logs

### ✅ **Configuración de Red**
- Detección automática de IP de red
- CORS configurado para desarrollo mobile/web
- Endpoints de información de red
- Logs con IPs para desarrollo local

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

### 🌐 **Configuración Avanzada**
- **CORS Dinámico**: Configuración por ambiente
- **Variables de Entorno**: Configuración flexible
- **Soporte Mobile**: Políticas específicas para apps móviles
- **Seguridad**: Configuración restrictiva en producción

---

*Desarrollado con ❤️ para el curso de Tópicos 2025*