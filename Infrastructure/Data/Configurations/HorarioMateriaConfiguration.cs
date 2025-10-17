using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HorarioMateriaConfiguration : IEntityTypeConfiguration<HorarioMateria>
    {
        public void Configure(EntityTypeBuilder<HorarioMateria> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("horario_materia");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.CuposDisponibles)
             .IsRequired()
             .HasColumnName("cupos_disponibles");
             
            b.Property(x => x.CuposTotal)
             .IsRequired()
             .HasColumnName("cupos_total");
             
            b.Property(x => x.NroAula)
             .HasColumnName("nro_aula");

            b.Property(x => x.GestionId)
             .IsRequired()
             .HasColumnName("gestion_id");
             
            b.Property(x => x.GrupoMateriaId)
             .IsRequired()
             .HasColumnName("grupo_materia_id");
             
            b.Property(x => x.ModuloId)
             .IsRequired()
             .HasColumnName("modulo_id");
             
            b.Property(x => x.DocenteId)
             .HasColumnName("docente_id");
             
            b.Property(x => x.HorarioId)
             .IsRequired()
             .HasColumnName("horario_id");

            b.HasOne(x => x.Gestion)
             .WithMany(g => g.HorariosMateria)
             .HasForeignKey(x => x.GestionId);

            b.HasOne(x => x.GrupoMateria)
             .WithMany(gm => gm.HorariosMateria)
             .HasForeignKey(x => x.GrupoMateriaId);

            b.HasOne(x => x.Modulo)
             .WithMany(m => m.HorariosMateria)
             .HasForeignKey(x => x.ModuloId);

            b.HasOne(x => x.Docente)
             .WithMany(d => d.HorariosMateria)
             .HasForeignKey(x => x.DocenteId)
             .OnDelete(DeleteBehavior.SetNull); // opcional

            b.HasOne(x => x.Horario)
             .WithMany(h => h.HorariosMateria)
             .HasForeignKey(x => x.HorarioId);

            b.HasMany(x => x.HorarioMateriaInscripciones)
             .WithOne(hmi => hmi.HorarioMateria)
             .HasForeignKey(hmi => hmi.HorarioMateriaId);
        }
    }
}
