using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.Credito).IsRequired();
            b.Property(x => x.EsElectiva).IsRequired();

            b.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            b.Property(x => x.Sigla).IsRequired().HasMaxLength(15);

            b.HasMany(x => x.MateriaPlanEstudios)
             .WithOne(mpe => mpe.Materia)
             .HasForeignKey(mpe => mpe.MateriaId);

            b.HasMany(x => x.GrupoMaterias)
             .WithOne(gm => gm.Materia)
             .HasForeignKey(gm => gm.MateriaId);
        }
    }
}
