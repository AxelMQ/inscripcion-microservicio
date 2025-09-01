using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HoraConfiguration : IEntityTypeConfiguration<Hora>
    {
        public void Configure(EntityTypeBuilder<Hora> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.HrInicio).IsRequired();
            b.Property(x => x.HrFin).IsRequired();

            b.HasMany(x => x.HorasDia)
             .WithOne(hd => hd.Hora)
             .HasForeignKey(hd => hd.HoraId);
        }
    }
}
