using Microsoft.EntityFrameworkCore;
using Domain.Models;
using System.Reflection;
using Application.Messages; // Necesitas importar este namespace

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // La línea clave para aplicar los seeders que creaste.
            // Esto busca todas las clases que implementan IEntityTypeConfiguration
            // en el mismo ensamblado y las aplica automáticamente.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Configuración para la clave primaria compuesta de PREREQUISITO
            modelBuilder.Entity<Prerequisito>()
                .HasKey(p => new { p.MATERIA_PLAN_ESTUDIO_ID, p.REQUISITO_ID });

            // Configuración de las relaciones para PREREQUISITO (muchos a muchos)
            modelBuilder.Entity<Prerequisito>()
                .HasOne(p => p.MateriaPlanEstudio)
                .WithMany(m => m.MateriasRequisito)
                .HasForeignKey(p => p.MATERIA_PLAN_ESTUDIO_ID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Prerequisito>()
                .HasOne(p => p.Requisito)
                .WithMany(m => m.RequisitosPara)
                .HasForeignKey(p => p.REQUISITO_ID)
                .OnDelete(DeleteBehavior.NoAction);

            // Configuración de relaciones para HoraDiaHorario
            modelBuilder.Entity<HoraDiaHorario>()
                .HasOne(hdh => hdh.HoraDia)
                .WithMany(hd => hd.HorasDiaHorario)
                .HasForeignKey(hdh => hdh.HORA_DIA_ID);

            modelBuilder.Entity<HoraDiaHorario>()
                .HasOne(hdh => hdh.Horario)
                .WithMany(h => h.HorasDiaHorario)
                .HasForeignKey(hdh => hdh.HORARIO_ID);

            // Configuración de relaciones para GrupoMateria
            modelBuilder.Entity<GrupoMateria>()
                .HasOne(g => g.Grupo)
                .WithMany(gm => gm.GrupoMaterias)
                .HasForeignKey(hdh => hdh.GRUPO_ID);

            modelBuilder.Entity<GrupoMateria>()
                .HasOne(m => m.Materia)
                .WithMany(h => h.GrupoMaterias)
                .HasForeignKey(hdh => hdh.MATERIA_ID);

            // Configuración de relaciones para HorarioMateria
            modelBuilder.Entity<HorarioMateria>()
                .HasOne(hm => hm.Gestion)
                .WithMany(g => g.HorariosMateria)
                .HasForeignKey(hm => hm.GESTION_ID);

            modelBuilder.Entity<HorarioMateria>()
                .HasOne(hm => hm.GrupoMateria)
                .WithMany(mpe => mpe.HorariosMateria)
                .HasForeignKey(hm => hm.GRUPO_MATERIA_ID);

            modelBuilder.Entity<HorarioMateria>()
                .HasOne(hm => hm.Modulo)
                .WithMany(m => m.HorariosMateria)
                .HasForeignKey(hm => hm.MODULO_ID);

            modelBuilder.Entity<HorarioMateria>()
                .HasOne(hm => hm.Docente)
                .WithMany(d => d.HorariosMateria)
                .HasForeignKey(hm => hm.DOCENTE_ID);

            modelBuilder.Entity<HorarioMateria>()
                .HasOne(hm => hm.Horario)
                .WithMany(h => h.HorariosMateria)
                .HasForeignKey(hm => hm.HORARIO_ID);

            // Configuración de relaciones para HoraDia
            modelBuilder.Entity<HoraDia>()
                .HasOne(hd => hd.Dia)
                .WithMany(d => d.HorasDia)
                .HasForeignKey(hd => hd.DIA_ID);

            modelBuilder.Entity<HoraDia>()
                .HasOne(hd => hd.Hora)
                .WithMany(h => h.HorasDia)
                .HasForeignKey(hd => hd.HORA_ID);

            // Configuración de relaciones para MateriaPlanEstudio
            modelBuilder.Entity<MateriaPlanEstudio>()
                .HasOne(mpe => mpe.Materia)
                .WithMany(m => m.MateriaPlanEstudios)
                .HasForeignKey(mpe => mpe.MATERIA_ID);

            modelBuilder.Entity<MateriaPlanEstudio>()
                .HasOne(mpe => mpe.Nivel)
                .WithMany(n => n.MateriaPlanEstudios)
                .HasForeignKey(mpe => mpe.NIVEL_ID);

            modelBuilder.Entity<MateriaPlanEstudio>()
                .HasOne(mpe => mpe.PlanEstudio)
                .WithMany(pe => pe.MateriaPlanEstudios)
                .HasForeignKey(mpe => mpe.PLAN_ESTUDIO_ID);

            // Configuración de relaciones para PlanEstudio
            modelBuilder.Entity<PlanEstudio>()
                .HasOne(pe => pe.Carrera)
                .WithMany(c => c.PlanesEstudio)
                .HasForeignKey(pe => pe.CARRERA_ID);

            // Configuración de relaciones para Inscripcion
            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Alumno)
                .WithMany(a => a.Inscripciones)
                .HasForeignKey(i => i.ALUMNO_ID);

            // Configuración de relaciones para HorarioMateriaInscripcion
            modelBuilder.Entity<HorarioMateriaInscripcion>()
                .HasOne(hmi => hmi.HorarioMateria)
                .WithMany(hm => hm.HorarioMateriaInscripciones)
                .HasForeignKey(hmi => hmi.HORARIO_MATERIA_ID);

            modelBuilder.Entity<HorarioMateriaInscripcion>()
                .HasOne(hmi => hmi.Inscripcion)
                .WithMany(i => i.HorarioMateriaInscripciones)
                .HasForeignKey(hmi => hmi.INSCRIPCION_ID);

            // Configuración de relaciones para Nota
            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Alumno)
                .WithMany(a => a.Notas)
                .HasForeignKey(n => n.ALUMNO_ID);

            modelBuilder.Entity<Nota>()
                .HasOne(n => n.HorarioMateriaInscripcion)
                .WithMany(hmi => hmi.Notas)
                .HasForeignKey(n => n.HORARIO_MATERIA_INSCRIPCION_ID);

            // Configuración de relaciones para AlumnoPlanEstudio
            modelBuilder.Entity<AlumnoPlanEstudio>()
                .HasOne(n => n.Alumno)
                .WithMany(a => a.AlumnoPlanEstudios)
                .HasForeignKey(n => n.ALUMNO_ID);

            modelBuilder.Entity<AlumnoPlanEstudio>()
                .HasOne(n => n.PlanEstudio)
                .WithMany(hmi => hmi.AlumnoPlanEstudios)
                .HasForeignKey(n => n.PLAN_ESTUDIO_ID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
