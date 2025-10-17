# 🌐 Endpoints del Microservicio

## 📊 **Información de Red**

### **🔍 Tu IP de Red Actual: `192.168.100.179`**

## 🚀 **Endpoints Principales**

### **🏥 Health & Status**
| Endpoint | Descripción | URL |
|----------|-------------|-----|
| **Health Check** | Estado del microservicio | `http://localhost:5239/api/health` |
| **Network Info** | Información de red para mobile/web | `http://localhost:5239/api/network-info` |
| **Ping** | Prueba simple de conectividad | `http://localhost:5239/api/ping` |

### **📚 Documentación**
| Endpoint | Descripción | URL |
|----------|-------------|-----|
| **Swagger UI** | Documentación interactiva de la API | `http://localhost:5239/swagger` |
| **Hangfire Dashboard** | Panel de trabajos en segundo plano | `http://localhost:5239/hangfire` |

### **🧪 Testing & Development**
| Endpoint | Descripción | URL |
|----------|-------------|-----|
| **Test Job** | Encolar un trabajo de prueba | `http://localhost:5239/test-job` |
| **Concurrencia Test** | Probar horarios disponibles | `http://localhost:5239/api/test/concurrencia` |
| **Jobs Errores** | Ver errores recientes de trabajos | `http://localhost:5239/api/jobs/errores` |
| **Logging Examples** | Ejemplos de logging con códigos HTTP | `http://localhost:5239/api/loggingexample/*` |

## 📱 **Para Desarrollo Mobile/Web**

### **🌐 URLs de Red**
```
Servidor Local:    http://localhost:5239
Servidor Red:      http://192.168.100.179:5239
```

### **📋 Endpoints para Mobile**
```json
{
  "base_url": "http://192.168.100.179:5239",
  "endpoints": {
    "health": "/api/health",
    "network_info": "/api/network-info",
    "ping": "/api/ping"
  }
}
```

### **🔧 Configuración CORS**
- **Desarrollo**: Permite `192.168.100.179` automáticamente
- **Mobile**: Usa política `MobileApp` con IPs dinámicas
- **Web**: Usa política `Development` con localhost

## 🎯 **Ejemplos de Uso**

### **1. Verificar Conectividad**
```bash
# Desde tu computadora
curl http://localhost:5239/api/health

# Desde tu móvil (misma red WiFi)
curl http://192.168.100.179:5239/api/health
```

### **2. Obtener Información de Red**
```bash
curl http://localhost:5239/api/network-info
```

**Respuesta:**
```json
{
  "message": "Información de red para desarrollo mobile/web",
  "server": {
    "localhost": "http://localhost:5239",
    "network": "http://192.168.100.179:5239",
    "ip": "192.168.100.179"
  },
  "endpoints": {
    "health": "http://localhost:5239/api/health",
    "swagger": "http://localhost:5239/swagger",
    "hangfire": "http://localhost:5239/hangfire",
    "network_health": "http://192.168.100.179:5239/api/health"
  },
  "timestamp": "2025-10-17T14:45:47.123Z"
}
```

### **3. Probar Logging**
```bash
# Éxito (HTTP 200)
curl http://localhost:5239/api/loggingexample/success

# Error 404
curl http://localhost:5239/api/loggingexample/not-found

# Error 401
curl http://localhost:5239/api/loggingexample/unauthorized

# Error 500
curl http://localhost:5239/api/loggingexample/server-error
```

## 🔍 **Logs en Tiempo Real**

### **Ver Logs**
```powershell
# Ver últimas líneas
Get-Content Api/logs/microservicio-20251017.log -Tail 20

# Seguir logs en tiempo real
Get-Content Api/logs/microservicio-20251017.log -Wait

# Filtrar solo errores
Get-Content Api/logs/microservicio-20251017.log | Select-String "ERR"
```

### **Ejemplo de Logs**
```
[10:45:42.748 INF] : ✅ Configuración de la aplicación completada
[10:45:42.757 INF] : 🌐 Servidor iniciando en: http://localhost:5239
[10:45:42.761 INF] : 📱 Para Mobile/Web usar: http://192.168.100.179:5239
[10:45:42.769 INF] : 📊 Dashboard Hangfire: http://localhost:5239/hangfire
[10:45:42.773 INF] : 📚 Documentación Swagger: http://localhost:5239/swagger
[10:45:42.776 INF] : ❤️ Health Check: http://localhost:5239/api/health
```

## 🛠️ **Configuración para Proyectos**

### **Flutter/React Native**
```dart
// Flutter
const String baseUrl = 'http://192.168.100.179:5239';

// React Native
const BASE_URL = 'http://192.168.100.179:5239';
```

### **Web (JavaScript)**
```javascript
const API_BASE_URL = 'http://192.168.100.179:5239';
```

### **Postman/Insomnia**
```
Base URL: http://192.168.100.179:5239
```

## ⚠️ **Notas Importantes**

1. **IP Cambia**: Si cambias de red WiFi, la IP cambiará
2. **CORS Configurado**: Ya está configurado para tu IP actual
3. **Logs Automáticos**: Se generan automáticamente en `Api/logs/`
4. **Swagger Corregido**: Ahora está en `/swagger` (no `/docs`)

## 🔄 **Si Cambias de Red**

1. **Reinicia la aplicación** para obtener la nueva IP
2. **Verifica los logs** para ver la nueva IP
3. **Actualiza tu proyecto mobile/web** con la nueva IP
4. **O usa variables de entorno** para no hardcodear la IP

## 📞 **Soporte**

- **Logs**: `Api/logs/microservicio-YYYYMMDD.log`
- **Documentación**: `Api/Documentation/`
- **Configuración**: `Api/appsettings.Development.json`
