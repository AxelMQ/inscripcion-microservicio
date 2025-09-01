using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(15);

            b.HasMany(x => x.GrupoMaterias)
             .WithOne(gm => gm.Grupo)
             .HasForeignKey(gm => gm.GrupoId);
        }
    }
}
