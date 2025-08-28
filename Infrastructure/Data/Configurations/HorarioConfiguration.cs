using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HorarioConfiguration : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> b)
        {
            b.HasKey(x => x.Id);

            b.HasMany(x => x.HorasDiaHorario)
             .WithOne(hdh => hdh.Horario)
             .HasForeignKey(hdh => hdh.HorarioId);

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Horario)
             .HasForeignKey(hm => hm.HorarioId);
        }
    }
}
