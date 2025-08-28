using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GrupoMateriaConfiguration : IEntityTypeConfiguration<GrupoMateria>
    {
        public void Configure(EntityTypeBuilder<GrupoMateria> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.GrupoId).IsRequired();
            b.Property(x => x.MateriaId).IsRequired();

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
