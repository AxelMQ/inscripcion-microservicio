// Infrastructure/Data/Configurations/PrerequisitoConfiguration.cs
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PrerequisitoConfiguration : IEntityTypeConfiguration<Prerequisito>
    {
        public void Configure(EntityTypeBuilder<Prerequisito> b)
        {
            // La clave primaria 'Id' se asume por convención. No es necesario configurarla.
            // Si la clase hereda de BaseEntity, EF Core la mapeará automáticamente.

            b.Property(x => x.MateriaPlanEstudioId).IsRequired();
            b.Property(x => x.RequisitoId).IsRequired();

            // Relaciones (auto-referencia a MPE en ambos lados)
            b.HasOne(x => x.MateriaPlanEstudio)
             .WithMany(mpe => mpe.MateriasRequisito) // “tiene estos prerequisitos”
             .HasForeignKey(x => x.MateriaPlanEstudioId)
             .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Requisito)
             .WithMany(mpe => mpe.RequisitosPara)    // “es requisito de estas materias”
             .HasForeignKey(x => x.RequisitoId)
             .OnDelete(DeleteBehavior.NoAction);

            // Se mantiene una restricción de unicidad para la combinación de las claves foráneas
            // Esto asegura que no se puedan crear prerequisitos duplicados
            b.HasIndex(x => new { x.MateriaPlanEstudioId, x.RequisitoId }).IsUnique();

            // Evita prerequisito a sí mismo
            b.ToTable(tb => tb.HasCheckConstraint("CK_prereq_no_self", "\"materia_plan_estudio_id\" <> \"requisito_id\""));
        }
    }
}
