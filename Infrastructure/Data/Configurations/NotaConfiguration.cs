using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class NotaConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.Calificacion)
             .IsRequired()
             .HasPrecision(10, 2);

            b.HasOne(x => x.Alumno)
             .WithMany(a => a.Notas)
             .HasForeignKey(x => x.AlumnoId)
             .OnDelete(DeleteBehavior.SetNull); // FK opcional

            b.HasOne(x => x.HorarioMateriaInscripcion)
             .WithMany(hmi => hmi.Notas)
             .HasForeignKey(x => x.HorarioMateriaInscripcionId)
             .OnDelete(DeleteBehavior.SetNull); // FK opcional
        }
    }
}
