using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HoraDiaConfiguration : IEntityTypeConfiguration<HoraDia>
    {
        public void Configure(EntityTypeBuilder<HoraDia> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("hora_dia");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.DiaId)
             .IsRequired()
             .HasColumnName("dia_id");
             
            b.Property(x => x.HoraId)
             .IsRequired()
             .HasColumnName("hora_id");

            b.HasOne(x => x.Dia)
             .WithMany(d => d.HorasDia)
             .HasForeignKey(x => x.DiaId);

            b.HasOne(x => x.Hora)
             .WithMany(h => h.HorasDia)
             .HasForeignKey(x => x.HoraId);

            b.HasMany(x => x.HorasDiaHorario)
             .WithOne(hdh => hdh.HoraDia)
             .HasForeignKey(hdh => hdh.HoraDiaId);
        }
    }
}
