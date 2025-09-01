using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CarreraConfiguration : IEntityTypeConfiguration<Carrera>
    {
        public void Configure(EntityTypeBuilder<Carrera> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.Codigo).IsRequired().HasMaxLength(10);
            b.Property(x => x.Modalidad).IsRequired();
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(63);

            b.HasMany(x => x.PlanesEstudio)
             .WithOne(pe => pe.Carrera)
             .HasForeignKey(pe => pe.CarreraId);
        }
    }
}
