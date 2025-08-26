using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HoraSeeder : IEntityTypeConfiguration<Hora>
{
  public void Configure(EntityTypeBuilder<Hora> builder)
  {
    builder.HasData(
        new Hora { ID = 1, HR_INICIO = new TimeOnly(7, 00), HR_FIN = new TimeOnly(8, 30) }, // 7.00 - 8.30
        new Hora { ID = 2, HR_INICIO = new TimeOnly(8, 30), HR_FIN = new TimeOnly(10, 00) }, // 8.30 - 10.00
        new Hora { ID = 3, HR_INICIO = new TimeOnly(10, 00), HR_FIN = new TimeOnly(11, 30) }, // 10.00 - 11.30
        new Hora { ID = 4, HR_INICIO = new TimeOnly(11, 30), HR_FIN = new TimeOnly(13, 00) }, // 11.30 - 13.00
        new Hora { ID = 5, HR_INICIO = new TimeOnly(13, 00), HR_FIN = new TimeOnly(14, 30) }, // 13.00 - 14.30

        new Hora { ID = 6, HR_INICIO = new TimeOnly(14, 30), HR_FIN = new TimeOnly(16, 00) }, // 14.30 - 16.00

        new Hora { ID = 7, HR_INICIO = new TimeOnly(07, 00), HR_FIN = new TimeOnly(09, 15) }, // 7.00 - 9.15  
        new Hora { ID = 8, HR_INICIO = new TimeOnly(09, 15), HR_FIN = new TimeOnly(11, 30) }, // 9.15 - 11.30
        new Hora { ID = 9, HR_INICIO = new TimeOnly(11, 30), HR_FIN = new TimeOnly(13, 00) }, // 11.30 - 13.00
        new Hora { ID = 10, HR_INICIO = new TimeOnly(16, 00), HR_FIN = new TimeOnly(18, 15) }, // 16.00 - 18.15
        new Hora { ID = 11, HR_INICIO = new TimeOnly(18, 15), HR_FIN = new TimeOnly(20, 30) }, // 18.15 - 20.30
        new Hora { ID = 12, HR_INICIO = new TimeOnly(20, 30), HR_FIN = new TimeOnly(22, 45) }, // 20.30 - 22.45

        new Hora { ID = 13, HR_INICIO = new TimeOnly(10, 00), HR_FIN = new TimeOnly(12, 15) }, // 10:00 - 12:15
        new Hora { ID = 14, HR_INICIO = new TimeOnly(11, 30), HR_FIN = new TimeOnly(13, 45) }, // 11:30 - 13:45

        new Hora { ID = 15, HR_INICIO = new TimeOnly(13, 45), HR_FIN = new TimeOnly(16, 00) }, // 13:45 - 16:00
        new Hora { ID = 16, HR_INICIO = new TimeOnly(15, 15), HR_FIN = new TimeOnly(16, 45) }, // 15:15 - 16:45
        new Hora { ID = 17, HR_INICIO = new TimeOnly(15, 15), HR_FIN = new TimeOnly(17, 30) }, // 15:15 - 17:30
        new Hora { ID = 18, HR_INICIO = new TimeOnly(17, 30), HR_FIN = new TimeOnly(19, 00) }, // 17:30 - 19:00
        new Hora { ID = 19, HR_INICIO = new TimeOnly(19, 00), HR_FIN = new TimeOnly(21, 15) }, // 19:00 - 21:15
        new Hora { ID = 20, HR_INICIO = new TimeOnly(19, 00), HR_FIN = new TimeOnly(20, 30) }, // 19:00 - 20:30
        new Hora { ID = 21, HR_INICIO = new TimeOnly(19, 45), HR_FIN = new TimeOnly(22, 00) }, // 19:45 - 22:00

        new Hora { ID = 22, HR_INICIO = new TimeOnly(10, 45), HR_FIN = new TimeOnly(13, 00) }, // 10:45 - 13:00

        new Hora { ID = 23, HR_INICIO = new TimeOnly(13, 45), HR_FIN = new TimeOnly(15, 15) }, // 13:45 - 15:15
        new Hora { ID = 24, HR_INICIO = new TimeOnly(13, 00), HR_FIN = new TimeOnly(15, 15) }, // 13:00 - 15:15
        new Hora { ID = 25, HR_INICIO = new TimeOnly(15, 15), HR_FIN = new TimeOnly(16, 45) }, // 15.15 - 16:45
        new Hora { ID = 26, HR_INICIO = new TimeOnly(16, 00), HR_FIN = new TimeOnly(17, 30) }, // 16.00 - 17:30
        new Hora { ID = 27, HR_INICIO = new TimeOnly(16, 45), HR_FIN = new TimeOnly(18, 15) }, // 16.45 - 18.15
        new Hora { ID = 28, HR_INICIO = new TimeOnly(18, 15), HR_FIN = new TimeOnly(19, 45) }, // 18.15 - 19.45
        new Hora { ID = 29, HR_INICIO = new TimeOnly(19, 45), HR_FIN = new TimeOnly(21, 15) }, // 19.45 - 21.15
        new Hora { ID = 30, HR_INICIO = new TimeOnly(21, 15), HR_FIN = new TimeOnly(22, 45) }, // 21.15 - 22.45
        new Hora { ID = 31, HR_INICIO = new TimeOnly(20, 30), HR_FIN = new TimeOnly(22, 00) }, // 20.30 - 22.00

        new Hora { ID = 32, HR_INICIO = new TimeOnly(12, 15), HR_FIN = new TimeOnly(13, 45) }, // 12.15 - 13.45
        new Hora { ID = 33, HR_INICIO = new TimeOnly(18, 26), HR_FIN = new TimeOnly(19, 45) }, // 18.26 - 19.45
        new Hora { ID = 34, HR_INICIO = new TimeOnly(09, 15), HR_FIN = new TimeOnly(10, 45) }, // 9.15 - 10.45
        new Hora { ID = 35, HR_INICIO = new TimeOnly(08, 30), HR_FIN = new TimeOnly(11, 30) }, // 8.30 - 11.30
        new Hora { ID = 36, HR_INICIO = new TimeOnly(13, 00), HR_FIN = new TimeOnly(16, 00) }, // 13:00 - 16:00
        new Hora { ID = 37, HR_INICIO = new TimeOnly(09, 15), HR_FIN = new TimeOnly(12, 15) }, // 09.15 - 12.15
        new Hora { ID = 38, HR_INICIO = new TimeOnly(18, 15), HR_FIN = new TimeOnly(21, 15) } // 18.15 - 21.15
    );
  }
}
