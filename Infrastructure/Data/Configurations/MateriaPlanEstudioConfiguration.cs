using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class MateriaPlanEstudioConfiguration : IEntityTypeConfiguration<MateriaPlanEstudio>
    {
        public void Configure(EntityTypeBuilder<MateriaPlanEstudio> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.MateriaId).IsRequired();
            b.Property(x => x.NivelId).IsRequired();
            b.Property(x => x.PlanEstudioId).IsRequired();

            b.HasOne(x => x.Materia)
             .WithMany(m => m.MateriaPlanEstudios)
             .HasForeignKey(x => x.MateriaId);

            b.HasOne(x => x.Nivel)
             .WithMany(n => n.MateriaPlanEstudios) // <-- asegúrate que Nivel tiene esta colección
             .HasForeignKey(x => x.NivelId);

            b.HasOne(x => x.PlanEstudio)
             .WithMany(pe => pe.MateriaPlanEstudios) // <-- asegúrate que PlanEstudio tiene esta colección
             .HasForeignKey(x => x.PlanEstudioId);

        }
    }
}
