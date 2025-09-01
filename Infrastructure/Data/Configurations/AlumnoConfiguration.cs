using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.Nombre)
             .IsRequired()
             .HasMaxLength(60);

            // Ajusta precisión de Ppa si lo necesitas fijo
            b.Property(x => x.Ppa)
             .HasPrecision(10, 2);

            // Telefono: sin restricciones; si lo cambiaste a string, queda así
            // Relaciones:
            b.HasMany(x => x.Inscripciones)
             .WithOne(i => i.Alumno)
             .HasForeignKey(i => i.AlumnoId);

            b.HasMany(x => x.Notas)
             .WithOne(n => n.Alumno)
             .HasForeignKey(n => n.AlumnoId);

            b.HasMany(x => x.AlumnoPlanEstudios)
             .WithOne(ape => ape.Alumno)
             .HasForeignKey(ape => ape.AlumnoId);
        }
    }
}
