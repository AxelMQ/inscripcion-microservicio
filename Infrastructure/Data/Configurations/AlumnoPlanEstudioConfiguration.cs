using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class AlumnoPlanEstudioConfiguration : IEntityTypeConfiguration<AlumnoPlanEstudio>
    {
        public void Configure(EntityTypeBuilder<AlumnoPlanEstudio> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.AlumnoId).IsRequired();
            b.Property(x => x.PlanEstudioId).IsRequired();

            b.HasOne(x => x.Alumno)
             .WithMany(a => a.AlumnoPlanEstudios)
             .HasForeignKey(x => x.AlumnoId);

            b.HasOne(x => x.PlanEstudio)
             .WithMany(pe => pe.AlumnoPlanEstudios)
             .HasForeignKey(x => x.PlanEstudioId);
        }
    }
}
