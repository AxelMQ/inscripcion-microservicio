using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HoraDiaSeeder : IEntityTypeConfiguration<HoraDia>
{
  public void Configure(EntityTypeBuilder<HoraDia> builder)
  {
    builder.HasData(

        // LUNES
        new HoraDia { ID = 1, DIA_ID = 1, HORA_ID = 1 }, // 7.00 - 8.30
        new HoraDia { ID = 2, DIA_ID = 1, HORA_ID = 7 }, // 7.00 - 9.15
        new HoraDia { ID = 3, DIA_ID = 1, HORA_ID = 2 }, // 8.30 - 10.00
        new HoraDia { ID = 4, DIA_ID = 1, HORA_ID = 8 }, // 9.15 - 11.30
        new HoraDia { ID = 5, DIA_ID = 1, HORA_ID = 3 }, // 10.00 - 11.30
        new HoraDia { ID = 6, DIA_ID = 1, HORA_ID = 4 }, // 11.30 - 13.00
        new HoraDia { ID = 7, DIA_ID = 1, HORA_ID = 32 }, // 12.15 - 13.45
        new HoraDia { ID = 8, DIA_ID = 1, HORA_ID = 5 },  // 13.00 - 14.30
        new HoraDia { ID = 9, DIA_ID = 1, HORA_ID = 23 }, // 13:45 - 15:15
        new HoraDia { ID = 10, DIA_ID = 1, HORA_ID = 15 }, // 13:45 - 16:00
        new HoraDia { ID = 11, DIA_ID = 1, HORA_ID = 25 }, // 15.15 - 16:45
        new HoraDia { ID = 12, DIA_ID = 1, HORA_ID = 10 }, // 16.00 - 18.15
        new HoraDia { ID = 13, DIA_ID = 1, HORA_ID = 26 }, // 16.00 - 17:30
        new HoraDia { ID = 14, DIA_ID = 1, HORA_ID = 27 }, // 16.45 - 18.15
        new HoraDia { ID = 15, DIA_ID = 1, HORA_ID = 28 }, // 18.15 - 19.45
        new HoraDia { ID = 16, DIA_ID = 1, HORA_ID = 20 }, // 19:00 - 20:30
        new HoraDia { ID = 17, DIA_ID = 1, HORA_ID = 21 }, // 19:45 - 22:00
        new HoraDia { ID = 18, DIA_ID = 1, HORA_ID = 29 }, // 19.45 - 21.15
        new HoraDia { ID = 19, DIA_ID = 1, HORA_ID = 31 }, // 20.30 - 22.00
        new HoraDia { ID = 20, DIA_ID = 1, HORA_ID = 30 }, // 21.15 - 22:45

        // MARTES
        new HoraDia { ID = 21, DIA_ID = 2, HORA_ID = 1 }, // 7.00 - 8.30
        new HoraDia { ID = 22, DIA_ID = 2, HORA_ID = 7 }, // 7.00 - 9.15
        new HoraDia { ID = 23, DIA_ID = 2, HORA_ID = 8 }, // 9.15 - 11.30
        new HoraDia { ID = 24, DIA_ID = 2, HORA_ID = 37 }, // 9.15 - 12.15
        new HoraDia { ID = 25, DIA_ID = 2, HORA_ID = 22 },  // 10:45 - 13:00
        new HoraDia { ID = 26, DIA_ID = 2, HORA_ID = 9 }, // 11:30 - 13:00
        new HoraDia { ID = 27, DIA_ID = 2, HORA_ID = 14 }, // 11:30 - 13:45
        new HoraDia { ID = 28, DIA_ID = 2, HORA_ID = 32 }, // 12.15 - 13.45
        new HoraDia { ID = 29, DIA_ID = 2, HORA_ID = 36 }, // 13:00 - 16:00
        new HoraDia { ID = 30, DIA_ID = 2, HORA_ID = 24 }, // 13:00 - 15:15
        new HoraDia { ID = 31, DIA_ID = 2, HORA_ID = 23 }, // 13:45 - 15:15
        new HoraDia { ID = 32, DIA_ID = 2, HORA_ID = 15 }, // 13:45 - 16:00
        new HoraDia { ID = 33, DIA_ID = 2, HORA_ID = 25 }, // 15.15 - 16:45
        new HoraDia { ID = 34, DIA_ID = 2, HORA_ID = 17 }, // 15.15 - 17:30
        new HoraDia { ID = 35, DIA_ID = 2, HORA_ID = 26 }, // 16.00 - 17:30
        new HoraDia { ID = 36, DIA_ID = 2, HORA_ID = 10 }, // 16.00 - 18.15
        new HoraDia { ID = 37, DIA_ID = 2, HORA_ID = 27 }, // 16.45 - 18.15
        new HoraDia { ID = 38, DIA_ID = 2, HORA_ID = 18 }, // 17:30 - 19:00
        new HoraDia { ID = 39, DIA_ID = 2, HORA_ID = 28 }, // 18.15 - 19.45
        new HoraDia { ID = 40, DIA_ID = 2, HORA_ID = 11 }, // 18.15 - 20.30
        new HoraDia { ID = 41, DIA_ID = 2, HORA_ID = 20 }, // 19:00 - 20:30
        new HoraDia { ID = 42, DIA_ID = 2, HORA_ID = 19 }, // 19:00 - 21:15
        new HoraDia { ID = 43, DIA_ID = 2, HORA_ID = 31 }, // 20.30 - 22.00
        new HoraDia { ID = 44, DIA_ID = 2, HORA_ID = 12 }, // 20.30 - 22.45
        new HoraDia { ID = 45, DIA_ID = 2, HORA_ID = 30 }, // 21.15 - 22:45

        // MIERCOLES
        new HoraDia { ID = 46, DIA_ID = 3, HORA_ID = 7 }, // 7.00 - 9.15
        new HoraDia { ID = 47, DIA_ID = 3, HORA_ID = 1 }, // 7.00 - 8.30
        new HoraDia { ID = 48, DIA_ID = 3, HORA_ID = 2 }, // 8.30 - 10.00
        new HoraDia { ID = 49, DIA_ID = 3, HORA_ID = 8 }, // 9.15 - 11.30
        new HoraDia { ID = 50, DIA_ID = 3, HORA_ID = 3 }, // 10.00 - 11.30
        new HoraDia { ID = 51, DIA_ID = 3, HORA_ID = 4 }, // 11.30 - 13.00
        new HoraDia { ID = 52, DIA_ID = 3, HORA_ID = 14 }, // 11:30 - 13:45
        new HoraDia { ID = 53, DIA_ID = 3, HORA_ID = 32 }, // 12.15 - 13.45
        new HoraDia { ID = 54, DIA_ID = 3, HORA_ID = 23 }, // 13:45 - 15:15
        new HoraDia { ID = 55, DIA_ID = 3, HORA_ID = 15 }, // 13:45 - 16:00
        new HoraDia { ID = 56, DIA_ID = 3, HORA_ID = 6 }, // 14.30 - 16.00
        new HoraDia { ID = 57, DIA_ID = 3, HORA_ID = 25 }, // 15.15 - 16:45
        new HoraDia { ID = 58, DIA_ID = 3, HORA_ID = 10 }, // 16.00 - 18.15
        new HoraDia { ID = 59, DIA_ID = 3, HORA_ID = 27 }, // 16.45 - 18.15
        new HoraDia { ID = 60, DIA_ID = 3, HORA_ID = 26 }, // 16.00 - 17:30
        new HoraDia { ID = 61, DIA_ID = 3, HORA_ID = 28 }, // 18.15 - 19.45
        new HoraDia { ID = 62, DIA_ID = 3, HORA_ID = 20 }, // 19:00 - 20:30
        new HoraDia { ID = 63, DIA_ID = 3, HORA_ID = 29 }, // 19.45 - 21.15
        new HoraDia { ID = 64, DIA_ID = 3, HORA_ID = 31 }, // 20.30 - 22.00
        new HoraDia { ID = 65, DIA_ID = 3, HORA_ID = 30 }, // 21.15 - 22:45

        

        // JUEVES
        new HoraDia { ID = 66, DIA_ID = 4, HORA_ID = 1 }, // 7.00 - 8.30
        new HoraDia { ID = 67, DIA_ID = 4, HORA_ID = 7 }, // 7.00 - 9.15
        new HoraDia { ID = 68, DIA_ID = 4, HORA_ID = 8 }, // 9.15 - 11.30
        new HoraDia { ID = 69, DIA_ID = 4, HORA_ID = 22 },  // 10:45 - 13:00 
        new HoraDia { ID = 70, DIA_ID = 4, HORA_ID = 14 }, // 11:30 - 13:45
        new HoraDia { ID = 71, DIA_ID = 4, HORA_ID = 24 }, // 13:00 - 15:15
        new HoraDia { ID = 72, DIA_ID = 4, HORA_ID = 15 }, // 13:45 - 16:00
        new HoraDia { ID = 73, DIA_ID = 4, HORA_ID = 17 }, // 15:15 - 17:30
        new HoraDia { ID = 74, DIA_ID = 4, HORA_ID = 25 }, // 15.15 - 16:45
        new HoraDia { ID = 75, DIA_ID = 4, HORA_ID = 26 }, // 16.00 - 17:30
        new HoraDia { ID = 76, DIA_ID = 4, HORA_ID = 10 }, // 16.00 - 18.15
        new HoraDia { ID = 77, DIA_ID = 4, HORA_ID = 18 }, // 17:30 - 19:00
        new HoraDia { ID = 78, DIA_ID = 4, HORA_ID = 28 }, // 18.15 - 19.45
        new HoraDia { ID = 79, DIA_ID = 4, HORA_ID = 11 }, // 18.15 - 20.30
        new HoraDia { ID = 80, DIA_ID = 4, HORA_ID = 20 }, // 19:00 - 20:30
        new HoraDia { ID = 81, DIA_ID = 4, HORA_ID = 19 }, // 19:00 - 21:15
        new HoraDia { ID = 82, DIA_ID = 4, HORA_ID = 31 }, // 20.30 - 22.00
        new HoraDia { ID = 83, DIA_ID = 4, HORA_ID = 12 },  // 20.30 - 22.45
        new HoraDia { ID = 84, DIA_ID = 4, HORA_ID = 30 }, // 21.15 - 22:45


        // VIERNES
        new HoraDia { ID = 85, DIA_ID = 5, HORA_ID = 1 }, // 7.00 - 8.30
        new HoraDia { ID = 86, DIA_ID = 5, HORA_ID = 7 }, // 7.00 - 9.15
        new HoraDia { ID = 87, DIA_ID = 5, HORA_ID = 2 }, // 8.30 - 10.00
        new HoraDia { ID = 88, DIA_ID = 5, HORA_ID = 8 }, // 9.15 - 11.30
        new HoraDia { ID = 89, DIA_ID = 5, HORA_ID = 3 }, // 10.00 - 11.30
        new HoraDia { ID = 90, DIA_ID = 5, HORA_ID = 13 }, // 10:00 - 12:15
        new HoraDia { ID = 91, DIA_ID = 3, HORA_ID = 4 }, // 11.30 - 13.00
        new HoraDia { ID = 92, DIA_ID = 5, HORA_ID = 14 }, // 11:30 - 13:45
        new HoraDia { ID = 93, DIA_ID = 5, HORA_ID = 32 }, // 12.15 - 13.45
        new HoraDia { ID = 94, DIA_ID = 5, HORA_ID = 15 }, // 13:45 - 16:00
        new HoraDia { ID = 95, DIA_ID = 5, HORA_ID = 23 }, // 13:45 - 15:15
        new HoraDia { ID = 96, DIA_ID = 5, HORA_ID = 25 }, // 15.15 - 16:45
        new HoraDia { ID = 97, DIA_ID = 5, HORA_ID = 26 }, // 16.00 - 17:30
        new HoraDia { ID = 98, DIA_ID = 5, HORA_ID = 27 }, // 16.45 - 18.15
        new HoraDia { ID = 99, DIA_ID = 5, HORA_ID = 38 }, // 18.15 - 21.15
        new HoraDia { ID = 100, DIA_ID = 5, HORA_ID = 28 }, // 18.15 - 19.45
        new HoraDia { ID = 101, DIA_ID = 5, HORA_ID = 20 }, // 19:00 - 20:30
        new HoraDia { ID = 102, DIA_ID = 5, HORA_ID = 21 }, // 19:45 - 22:00
        new HoraDia { ID = 103, DIA_ID = 5, HORA_ID = 29 }, // 19.45 - 21.15
        new HoraDia { ID = 104, DIA_ID = 5, HORA_ID = 31 }, // 20.30 - 22.00
        new HoraDia { ID = 105, DIA_ID = 5, HORA_ID = 30 }, // 21.15 - 22:45

        
        // SABADO 
        new HoraDia { ID = 106, DIA_ID = 6, HORA_ID = 1 }, // 7.00 - 8.30 -- SABADO
        new HoraDia { ID = 107, DIA_ID = 6, HORA_ID = 2 }, // 8.30 - 10.00 -- SABADO
        new HoraDia { ID = 108, DIA_ID = 6, HORA_ID = 35 }, // 8.30 - 11.30 -- SABADO
        new HoraDia { ID = 109, DIA_ID = 6, HORA_ID = 34 }, // 09.15 - 10.45 -- SABADO
        new HoraDia { ID = 110, DIA_ID = 6, HORA_ID = 13 }, // 10:00 - 12:15 -- SABADO
        new HoraDia { ID = 111, DIA_ID = 6, HORA_ID = 25 }, // 15.15 - 16:45
        new HoraDia { ID = 112, DIA_ID = 6, HORA_ID = 28 }, // 18.15 - 19.45 -- SABADO
        new HoraDia { ID = 113, DIA_ID = 6, HORA_ID = 33 }, // 18.26 - 19.45 -- SABADO

        
        new HoraDia { ID = 114, DIA_ID = 3, HORA_ID = 22 },  // 10:45 - 13:00 
        new HoraDia { ID = 115, DIA_ID = 5, HORA_ID = 22 },  // 10:45 - 13:00 
        new HoraDia { ID = 116, DIA_ID = 3, HORA_ID = 21 } // 19:45 - 22:00
    );
  }
}
