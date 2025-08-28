using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DiaConfiguration : IEntityTypeConfiguration<Dia>
    {
        public void Configure(EntityTypeBuilder<Dia> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(15);

            b.HasMany(x => x.HorasDia)
             .WithOne(hd => hd.Dia)
             .HasForeignKey(hd => hd.DiaId);
        }
    }
}
