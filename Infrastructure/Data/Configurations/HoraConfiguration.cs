using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HoraConfiguration : IEntityTypeConfiguration<Hora>
    {
        public void Configure(EntityTypeBuilder<Hora> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("hora");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.HrInicio)
             .IsRequired()
             .HasColumnName("hr_inicio");
             
            b.Property(x => x.HrFin)
             .IsRequired()
             .HasColumnName("hr_fin");

            b.HasMany(x => x.HorasDia)
             .WithOne(hd => hd.Hora)
             .HasForeignKey(hd => hd.HoraId);
        }
    }
}
