using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Reflection;
using Application.Messages;
using Domain.Core; // Necesitas importar este namespace

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        // El constructor es necesario para la inyección de dependencias
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Aquí defines un DbSet para cada tabla de tu base de datos.
        // Esto le indica a Entity Framework qué clases de modelo debe mapear.
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Dia> Dia { get; set; }
        public DbSet<Hora> Hora { get; set; }
        public DbSet<Gestion> Gestion { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<PlanEstudio> PlanEstudio { get; set; }
        public DbSet<MateriaPlanEstudio> MateriaPlanEstudio { get; set; }
        public DbSet<Prerequisito> Prerequisito { get; set; }
        public DbSet<HoraDia> HoraDia { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<HoraDiaHorario> HoraDiaHorario { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<HorarioMateria> HorarioMateria { get; set; }
        public DbSet<HorarioMateriaInscripcion> HorarioMateriaInscripcion { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<GrupoMateria> GrupoMateria { get; set; }
        public DbSet<AlumnoPlanEstudio> AlumnoPlanEstudio { get; set; }

        // Este método se usa para configurar el modelo de datos,
        // especialmente para relaciones y claves compuestas.

        // Sobrescribimos SaveChangesAsync para manejar automáticamente las fechas
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // Busca todas las entidades que están siendo agregadas o modificadas
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                // Si la entidad se está agregando, establece la fecha de creación
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.UtcNow;
                }

                // Actualiza la fecha de modificación para todas las entidades que cambian
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
