using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ModuloConfiguration : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.NroModulo).IsRequired();

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Modulo)
             .HasForeignKey(hm => hm.ModuloId);
        }
    }
}
