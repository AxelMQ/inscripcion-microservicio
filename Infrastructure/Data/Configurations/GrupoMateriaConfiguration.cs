using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GrupoMateriaConfiguration : IEntityTypeConfiguration<GrupoMateria>
    {
        public void Configure(EntityTypeBuilder<GrupoMateria> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("grupo_materia");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.GrupoId)
             .IsRequired()
             .HasColumnName("grupo_id");
             
            b.Property(x => x.MateriaId)
             .IsRequired()
             .HasColumnName("materia_id");

            b.HasOne(x => x.Grupo)
             .WithMany(g => g.GrupoMaterias)
             .HasForeignKey(x => x.GrupoId);

            b.HasOne(x => x.Materia)
             .WithMany(m => m.GrupoMaterias)
             .HasForeignKey(x => x.MateriaId);

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.GrupoMateria)
             .HasForeignKey(hm => hm.GrupoMateriaId);
        }
    }
}
