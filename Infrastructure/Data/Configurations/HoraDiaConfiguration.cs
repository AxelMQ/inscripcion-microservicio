using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HoraDiaConfiguration : IEntityTypeConfiguration<HoraDia>
    {
        public void Configure(EntityTypeBuilder<HoraDia> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.DiaId).IsRequired();
            b.Property(x => x.HoraId).IsRequired();

            b.HasOne(x => x.Dia)
             .WithMany(d => d.HorasDia)
             .HasForeignKey(x => x.DiaId);

            b.HasOne(x => x.Hora)
             .WithMany(h => h.HorasDia)
             .HasForeignKey(x => x.HoraId);

            b.HasMany(x => x.HorasDiaHorario)
             .WithOne(hdh => hdh.HoraDia)
             .HasForeignKey(hdh => hdh.HoraDiaId);
        }
    }
}
