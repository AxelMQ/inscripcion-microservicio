# 📌 Proyecto .NET con Entity Framework Core

Este proyecto utiliza **.NET 8** y **Entity Framework Core** para la gestión de base de datos mediante migraciones.

---

## 🚀 Levantar el proyecto

Para iniciar la API desde la raíz de la solución:

    dotnet run --project Api

---

## 🗄️ Migraciones y base de datos

### ➕ Crear una nueva migración
Crea una migración (cambia `Initial` por el nombre que necesites):

    dotnet ef migrations add Initial --project Infrastructure --startup-project Api

### 📥 Aplicar la migración (crear/actualizar la base de datos)
Aplica la última migración a la base de datos:

    dotnet ef database update --project Infrastructure --startup-project Api

### ❌ Eliminar la base de datos
Dirígete primero a la carpeta **Api**, luego ejecuta:

    dotnet ef database drop

### 🔄 Aplicar cambios recientes en la base de datos
Si ya creaste migraciones nuevas y solo quieres aplicarlas:

    dotnet ef database update

---

## 📋 Notas importantes

- Instala la CLI de EF Core (si no la tienes):
  
      dotnet tool install --global dotnet-ef

- Ejecuta los comandos desde la **raíz de la solución**, salvo donde se indique (por ejemplo, `database drop` dentro de `Api`).
- Asegúrate de configurar la cadena de conexión en `Api/appsettings.Development.json` (y/o `appsettings.json`) antes de aplicar migraciones.
- Organización típica por capas:
  - **Api** → proyecto de inicio (*startup project*).
  - **Infrastructure** → persistencia y migraciones.
  - **Domain**, **Application**, **Shared** (si corresponde).

---

## 📦 Estructura recomendada del proyecto

