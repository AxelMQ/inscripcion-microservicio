using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HorarioMateriaInscripcionConfiguration : IEntityTypeConfiguration<HorarioMateriaInscripcion>
    {
        public void Configure(EntityTypeBuilder<HorarioMateriaInscripcion> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.HorarioMateriaId).IsRequired();
            b.Property(x => x.InscripcionId).IsRequired();

            b.HasOne(x => x.HorarioMateria)
             .WithMany(hm => hm.HorarioMateriaInscripciones)
             .HasForeignKey(x => x.HorarioMateriaId);

            b.HasOne(x => x.Inscripcion)
             .WithMany(i => i.HorarioMateriaInscripciones)
             .HasForeignKey(x => x.InscripcionId);

            b.HasMany(x => x.Notas)
             .WithOne(n => n.HorarioMateriaInscripcion)
             .HasForeignKey(n => n.HorarioMateriaInscripcionId);
        }
    }
}
