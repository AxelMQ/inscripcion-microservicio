using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HoraDiaHorarioConfiguration : IEntityTypeConfiguration<HoraDiaHorario>
    {
        public void Configure(EntityTypeBuilder<HoraDiaHorario> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.HoraDiaId).IsRequired();
            b.Property(x => x.HorarioId).IsRequired();

            b.HasOne(x => x.HoraDia)
             .WithMany(hd => hd.HorasDiaHorario)
             .HasForeignKey(x => x.HoraDiaId);

            b.HasOne(x => x.Horario)
             .WithMany(h => h.HorasDiaHorario)
             .HasForeignKey(x => x.HorarioId);
        }
    }
}
