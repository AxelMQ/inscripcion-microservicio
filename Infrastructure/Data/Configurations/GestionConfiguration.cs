using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GestionConfiguration : IEntityTypeConfiguration<Gestion>
    {
        public void Configure(EntityTypeBuilder<Gestion> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("gestion");
            
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
             .HasMaxLength(25)
             .HasColumnName("nombre");

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Gestion)
             .HasForeignKey(hm => hm.GestionId);
        }
    }
}
