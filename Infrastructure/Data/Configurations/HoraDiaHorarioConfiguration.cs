using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HoraDiaHorarioConfiguration : IEntityTypeConfiguration<HoraDiaHorario>
    {
        public void Configure(EntityTypeBuilder<HoraDiaHorario> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("hora_dia_horario");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.HoraDiaId)
             .IsRequired()
             .HasColumnName("hora_dia_id");
             
            b.Property(x => x.HorarioId)
             .IsRequired()
             .HasColumnName("horario_id");

            b.HasOne(x => x.HoraDia)
             .WithMany(hd => hd.HorasDiaHorario)
             .HasForeignKey(x => x.HoraDiaId);

            b.HasOne(x => x.Horario)
             .WithMany(h => h.HorasDiaHorario)
             .HasForeignKey(x => x.HorarioId);
        }
    }
}
