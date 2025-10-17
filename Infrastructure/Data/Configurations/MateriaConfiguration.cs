using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("materia");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.Credito)
             .IsRequired()
             .HasColumnName("credito");
             
            b.Property(x => x.EsElectiva)
             .IsRequired()
             .HasColumnName("es_electiva");

            b.Property(x => x.Nombre)
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnName("nombre");
             
            b.Property(x => x.Sigla)
             .IsRequired()
             .HasMaxLength(15)
             .HasColumnName("sigla");

            b.HasMany(x => x.MateriaPlanEstudios)
             .WithOne(mpe => mpe.Materia)
             .HasForeignKey(mpe => mpe.MateriaId);

            b.HasMany(x => x.GrupoMaterias)
             .WithOne(gm => gm.Materia)
             .HasForeignKey(gm => gm.MateriaId);
        }
    }
}
