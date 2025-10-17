# Variables de Entorno para Configuración

## Configuración de CORS

### Variables Principales

```bash
# Ambiente de la aplicación
ASPNETCORE_ENVIRONMENT=Development|Staging|Production

# Política CORS a usar
CORS_POLICY=Development|DynamicCors|MobileApp

# Orígenes permitidos (separados por coma)
CORS_ALLOWED_ORIGINS=http://localhost:3000,http://192.168.0.15:3000,https://tuapp.com

# Métodos HTTP permitidos
CORS_ALLOWED_METHODS=GET,POST,PUT,DELETE,OPTIONS

# Headers permitidos
CORS_ALLOWED_HEADERS=Content-Type,Authorization,X-Requested-With

# IPs permitidas para mobile apps
MOBILE_ALLOWED_IPS=192.168.,10.,localhost
```

## Configuración por Ambiente

### Desarrollo
```bash
ASPNETCORE_ENVIRONMENT=Development
CORS_POLICY=Development
```

### Staging
```bash
ASPNETCORE_ENVIRONMENT=Staging
CORS_POLICY=DynamicCors
CORS_ALLOWED_ORIGINS=https://staging.tuapp.com,https://staging-api.tuapp.com
```

### Producción
```bash
ASPNETCORE_ENVIRONMENT=Production
CORS_POLICY=DynamicCors
CORS_ALLOWED_ORIGINS=https://tuapp.com,https://www.tuapp.com,https://api.tuapp.com
```

## Cómo Usar

1. **En desarrollo**: No necesitas configurar nada, usa los valores por defecto
2. **En staging/producción**: Configura las variables de entorno en tu servidor
3. **Para mobile**: Usa `CORS_POLICY=MobileApp` y configura `MOBILE_ALLOWED_IPS`
