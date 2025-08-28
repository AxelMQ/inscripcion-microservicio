using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
    {
        public void Configure(EntityTypeBuilder<Nivel> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            b.Property(x => x.Orden).IsRequired();

            b.HasMany(x => x.MateriaPlanEstudios)
             .WithOne(mpe => mpe.Nivel)
             .HasForeignKey(mpe => mpe.NivelId);
        }
    }
}
