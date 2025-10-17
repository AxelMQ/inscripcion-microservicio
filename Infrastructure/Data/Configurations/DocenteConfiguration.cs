using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("docente");
            
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
             .HasMaxLength(125)
             .HasColumnName("nombre");
             
            b.Property(x => x.Ci)
             .IsRequired()
             .HasColumnName("ci");
             
            b.Property(x => x.Telefono)
             .HasColumnName("telefono");

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Docente)
             .HasForeignKey(hm => hm.DocenteId)
             .OnDelete(DeleteBehavior.SetNull); // FK opcional
        }
    }
}
