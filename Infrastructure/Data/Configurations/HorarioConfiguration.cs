using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HorarioConfiguration : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("horario");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.HasMany(x => x.HorasDiaHorario)
             .WithOne(hdh => hdh.Horario)
             .HasForeignKey(hdh => hdh.HorarioId);

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Horario)
             .HasForeignKey(hm => hm.HorarioId);
        }
    }
}
