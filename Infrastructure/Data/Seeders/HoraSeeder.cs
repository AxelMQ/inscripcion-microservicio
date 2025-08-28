using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HoraSeeder : IEntityTypeConfiguration<Hora>
{
  public void Configure(EntityTypeBuilder<Hora> builder)
  {
    builder.HasData(
        new Hora { Id = 1, HrInicio = new TimeOnly(7, 00), HrFin = new TimeOnly(8, 30) }, // 7.00 - 8.30
        new Hora { Id = 2, HrInicio = new TimeOnly(8, 30), HrFin = new TimeOnly(10, 00) }, // 8.30 - 10.00
        new Hora { Id = 3, HrInicio = new TimeOnly(10, 00), HrFin = new TimeOnly(11, 30) }, // 10.00 - 11.30
        new Hora { Id = 4, HrInicio = new TimeOnly(11, 30), HrFin = new TimeOnly(13, 00) }, // 11.30 - 13.00
        new Hora { Id = 5, HrInicio = new TimeOnly(13, 00), HrFin = new TimeOnly(14, 30) }, // 13.00 - 14.30

        new Hora { Id = 6, HrInicio = new TimeOnly(14, 30), HrFin = new TimeOnly(16, 00) }, // 14.30 - 16.00

        new Hora { Id = 7, HrInicio = new TimeOnly(07, 00), HrFin = new TimeOnly(09, 15) }, // 7.00 - 9.15  
        new Hora { Id = 8, HrInicio = new TimeOnly(09, 15), HrFin = new TimeOnly(11, 30) }, // 9.15 - 11.30
        new Hora { Id = 9, HrInicio = new TimeOnly(11, 30), HrFin = new TimeOnly(13, 00) }, // 11.30 - 13.00
        new Hora { Id = 10, HrInicio = new TimeOnly(16, 00), HrFin = new TimeOnly(18, 15) }, // 16.00 - 18.15
        new Hora { Id = 11, HrInicio = new TimeOnly(18, 15), HrFin = new TimeOnly(20, 30) }, // 18.15 - 20.30
        new Hora { Id = 12, HrInicio = new TimeOnly(20, 30), HrFin = new TimeOnly(22, 45) }, // 20.30 - 22.45

        new Hora { Id = 13, HrInicio = new TimeOnly(10, 00), HrFin = new TimeOnly(12, 15) }, // 10:00 - 12:15
        new Hora { Id = 14, HrInicio = new TimeOnly(11, 30), HrFin = new TimeOnly(13, 45) }, // 11:30 - 13:45

        new Hora { Id = 15, HrInicio = new TimeOnly(13, 45), HrFin = new TimeOnly(16, 00) }, // 13:45 - 16:00
        new Hora { Id = 16, HrInicio = new TimeOnly(15, 15), HrFin = new TimeOnly(16, 45) }, // 15:15 - 16:45
        new Hora { Id = 17, HrInicio = new TimeOnly(15, 15), HrFin = new TimeOnly(17, 30) }, // 15:15 - 17:30
        new Hora { Id = 18, HrInicio = new TimeOnly(17, 30), HrFin = new TimeOnly(19, 00) }, // 17:30 - 19:00
        new Hora { Id = 19, HrInicio = new TimeOnly(19, 00), HrFin = new TimeOnly(21, 15) }, // 19:00 - 21:15
        new Hora { Id = 20, HrInicio = new TimeOnly(19, 00), HrFin = new TimeOnly(20, 30) }, // 19:00 - 20:30
        new Hora { Id = 21, HrInicio = new TimeOnly(19, 45), HrFin = new TimeOnly(22, 00) }, // 19:45 - 22:00

        new Hora { Id = 22, HrInicio = new TimeOnly(10, 45), HrFin = new TimeOnly(13, 00) }, // 10:45 - 13:00

        new Hora { Id = 23, HrInicio = new TimeOnly(13, 45), HrFin = new TimeOnly(15, 15) }, // 13:45 - 15:15
        new Hora { Id = 24, HrInicio = new TimeOnly(13, 00), HrFin = new TimeOnly(15, 15) }, // 13:00 - 15:15
        new Hora { Id = 25, HrInicio = new TimeOnly(15, 15), HrFin = new TimeOnly(16, 45) }, // 15.15 - 16:45
        new Hora { Id = 26, HrInicio = new TimeOnly(16, 00), HrFin = new TimeOnly(17, 30) }, // 16.00 - 17:30
        new Hora { Id = 27, HrInicio = new TimeOnly(16, 45), HrFin = new TimeOnly(18, 15) }, // 16.45 - 18.15
        new Hora { Id = 28, HrInicio = new TimeOnly(18, 15), HrFin = new TimeOnly(19, 45) }, // 18.15 - 19.45
        new Hora { Id = 29, HrInicio = new TimeOnly(19, 45), HrFin = new TimeOnly(21, 15) }, // 19.45 - 21.15
        new Hora { Id = 30, HrInicio = new TimeOnly(21, 15), HrFin = new TimeOnly(22, 45) }, // 21.15 - 22.45
        new Hora { Id = 31, HrInicio = new TimeOnly(20, 30), HrFin = new TimeOnly(22, 00) }, // 20.30 - 22.00

        new Hora { Id = 32, HrInicio = new TimeOnly(12, 15), HrFin = new TimeOnly(13, 45) }, // 12.15 - 13.45
        new Hora { Id = 33, HrInicio = new TimeOnly(18, 26), HrFin = new TimeOnly(19, 45) }, // 18.26 - 19.45
        new Hora { Id = 34, HrInicio = new TimeOnly(09, 15), HrFin = new TimeOnly(10, 45) }, // 9.15 - 10.45
        new Hora { Id = 35, HrInicio = new TimeOnly(08, 30), HrFin = new TimeOnly(11, 30) }, // 8.30 - 11.30
        new Hora { Id = 36, HrInicio = new TimeOnly(13, 00), HrFin = new TimeOnly(16, 00) }, // 13:00 - 16:00
        new Hora { Id = 37, HrInicio = new TimeOnly(09, 15), HrFin = new TimeOnly(12, 15) }, // 09.15 - 12.15
        new Hora { Id = 38, HrInicio = new TimeOnly(18, 15), HrFin = new TimeOnly(21, 15) } // 18.15 - 21.15
    );
  }
}
