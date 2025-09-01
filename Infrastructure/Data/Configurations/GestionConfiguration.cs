using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GestionConfiguration : IEntityTypeConfiguration<Gestion>
    {
        public void Configure(EntityTypeBuilder<Gestion> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(25);

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Gestion)
             .HasForeignKey(hm => hm.GestionId);
        }
    }
}
