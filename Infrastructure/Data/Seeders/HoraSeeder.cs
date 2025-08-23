using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HoraSeeder : IEntityTypeConfiguration<Hora>
{
  public void Configure(EntityTypeBuilder<Hora> builder)
  {
    builder.HasData(
        new Hora { ID = 1, HR_INICIO = new TimeOnly(7, 00), HR_FIN = new TimeOnly(8, 30) },
        new Hora { ID = 2, HR_INICIO = new TimeOnly(8, 30), HR_FIN = new TimeOnly(10, 30) }
    );
  }
}
