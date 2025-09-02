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
            // PK natural: (materia, requisito)
            b.HasKey(x => new { x.MateriaPlanEstudioId, x.RequisitoId });

            // Ignora el Id heredado de BaseEntity (no lo mapees a la BD)
            b.Ignore(x => x.Id);

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

            // Evita prerequisito a sí mismo
            b.ToTable(tb => tb.HasCheckConstraint("CK_prereq_no_self", "\"materia_plan_estudio_id\" <> \"requisito_id\""));


            // Índices útiles para consultas en ambos sentidos
            b.HasIndex(x => x.MateriaPlanEstudioId);
            b.HasIndex(x => x.RequisitoId);
        }
    }
}
