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
        new Hora { ID = 2, HR_INICIO = new TimeOnly(8, 30), HR_FIN = new TimeOnly(10, 00) },
        new Hora { ID = 3, HR_INICIO = new TimeOnly(10, 00), HR_FIN = new TimeOnly(11, 30) },
        new Hora { ID = 4, HR_INICIO = new TimeOnly(11, 30), HR_FIN = new TimeOnly(13, 00) },
        new Hora { ID = 5, HR_INICIO = new TimeOnly(13, 00), HR_FIN = new TimeOnly(14, 30) },

        new Hora { ID = 6, HR_INICIO = new TimeOnly(14, 30), HR_FIN = new TimeOnly(16, 00) },
        
        new Hora { ID = 7, HR_INICIO = new TimeOnly(07, 00), HR_FIN = new TimeOnly(09, 15) },
        new Hora { ID = 8, HR_INICIO = new TimeOnly(09, 15), HR_FIN = new TimeOnly(11, 30) },
        new Hora { ID = 9, HR_INICIO = new TimeOnly(11, 30), HR_FIN = new TimeOnly(13, 00) },
        new Hora { ID = 10, HR_INICIO = new TimeOnly(16, 00), HR_FIN = new TimeOnly(18, 15) },
        new Hora { ID = 11, HR_INICIO = new TimeOnly(18, 15), HR_FIN = new TimeOnly(20, 30) },
        new Hora { ID = 12, HR_INICIO = new TimeOnly(20, 30), HR_FIN = new TimeOnly(22, 45) }
    );
  }
}
