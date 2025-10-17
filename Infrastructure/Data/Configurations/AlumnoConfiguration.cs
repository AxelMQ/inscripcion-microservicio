using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("alumno");
            
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");
            
            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            b.Property(x => x.Nombre)
             .IsRequired()
             .HasMaxLength(60)
             .HasColumnName("nombre");

            // Ajusta precisión de Ppa si lo necesitas fijo
            b.Property(x => x.Ppa)
             .HasPrecision(10, 2)
             .HasColumnName("ppa");

            // Telefono: sin restricciones; si lo cambiaste a string, queda así
            b.Property(x => x.Telefono)
             .HasColumnName("telefono");
             
            b.Property(x => x.Registro)
             .HasColumnName("registro");
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
