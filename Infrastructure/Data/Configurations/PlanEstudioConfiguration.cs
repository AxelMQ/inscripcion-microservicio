using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PlanEstudioConfiguration : IEntityTypeConfiguration<PlanEstudio>
    {
        public void Configure(EntityTypeBuilder<PlanEstudio> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.Codigo).IsRequired().HasMaxLength(10);
            b.Property(x => x.CarreraId).IsRequired();

            b.HasOne(x => x.Carrera)
             .WithMany(c => c.PlanesEstudio)
             .HasForeignKey(x => x.CarreraId);

            b.HasMany(x => x.MateriaPlanEstudios)
             .WithOne(mpe => mpe.PlanEstudio)
             .HasForeignKey(mpe => mpe.PlanEstudioId);

            b.HasMany(x => x.AlumnoPlanEstudios)
             .WithOne(ape => ape.PlanEstudio)
             .HasForeignKey(ape => ape.PlanEstudioId);
        }
    }
}
