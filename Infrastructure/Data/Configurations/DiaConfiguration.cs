using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DiaConfiguration : IEntityTypeConfiguration<Dia>
    {
        public void Configure(EntityTypeBuilder<Dia> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("dia");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.Nombre)
             .IsRequired()
             .HasMaxLength(15)
             .HasColumnName("nombre");

            b.HasMany(x => x.HorasDia)
             .WithOne(hd => hd.Dia)
             .HasForeignKey(hd => hd.DiaId);
        }
    }
}
