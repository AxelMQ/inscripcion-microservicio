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
        new HoraDia { Id = 1, DiaId = 1, HoraId = 1 }, // 7.00 - 8.30
        new HoraDia { Id = 2, DiaId = 1, HoraId = 7 }, // 7.00 - 9.15
        new HoraDia { Id = 3, DiaId = 1, HoraId = 2 }, // 8.30 - 10.00
        new HoraDia { Id = 4, DiaId = 1, HoraId = 8 }, // 9.15 - 11.30
        new HoraDia { Id = 5, DiaId = 1, HoraId = 3 }, // 10.00 - 11.30
        new HoraDia { Id = 6, DiaId = 1, HoraId = 4 }, // 11.30 - 13.00
        new HoraDia { Id = 7, DiaId = 1, HoraId = 32 }, // 12.15 - 13.45
        new HoraDia { Id = 8, DiaId = 1, HoraId = 5 },  // 13.00 - 14.30
        new HoraDia { Id = 9, DiaId = 1, HoraId = 23 }, // 13:45 - 15:15
        new HoraDia { Id = 10, DiaId = 1, HoraId = 15 }, // 13:45 - 16:00
        new HoraDia { Id = 11, DiaId = 1, HoraId = 25 }, // 15.15 - 16:45
        new HoraDia { Id = 12, DiaId = 1, HoraId = 10 }, // 16.00 - 18.15
        new HoraDia { Id = 13, DiaId = 1, HoraId = 26 }, // 16.00 - 17:30
        new HoraDia { Id = 14, DiaId = 1, HoraId = 27 }, // 16.45 - 18.15
        new HoraDia { Id = 15, DiaId = 1, HoraId = 28 }, // 18.15 - 19.45
        new HoraDia { Id = 16, DiaId = 1, HoraId = 20 }, // 19:00 - 20:30
        new HoraDia { Id = 17, DiaId = 1, HoraId = 21 }, // 19:45 - 22:00
        new HoraDia { Id = 18, DiaId = 1, HoraId = 29 }, // 19.45 - 21.15
        new HoraDia { Id = 19, DiaId = 1, HoraId = 31 }, // 20.30 - 22.00
        new HoraDia { Id = 20, DiaId = 1, HoraId = 30 }, // 21.15 - 22:45

        // MARTES
        new HoraDia { Id = 21, DiaId = 2, HoraId = 1 }, // 7.00 - 8.30
        new HoraDia { Id = 22, DiaId = 2, HoraId = 7 }, // 7.00 - 9.15
        new HoraDia { Id = 23, DiaId = 2, HoraId = 8 }, // 9.15 - 11.30
        new HoraDia { Id = 24, DiaId = 2, HoraId = 37 }, // 9.15 - 12.15
        new HoraDia { Id = 25, DiaId = 2, HoraId = 22 },  // 10:45 - 13:00
        new HoraDia { Id = 26, DiaId = 2, HoraId = 9 }, // 11:30 - 13:00
        new HoraDia { Id = 27, DiaId = 2, HoraId = 14 }, // 11:30 - 13:45
        new HoraDia { Id = 28, DiaId = 2, HoraId = 32 }, // 12.15 - 13.45
        new HoraDia { Id = 29, DiaId = 2, HoraId = 36 }, // 13:00 - 16:00
        new HoraDia { Id = 30, DiaId = 2, HoraId = 24 }, // 13:00 - 15:15
        new HoraDia { Id = 31, DiaId = 2, HoraId = 23 }, // 13:45 - 15:15
        new HoraDia { Id = 32, DiaId = 2, HoraId = 15 }, // 13:45 - 16:00
        new HoraDia { Id = 33, DiaId = 2, HoraId = 25 }, // 15.15 - 16:45
        new HoraDia { Id = 34, DiaId = 2, HoraId = 17 }, // 15.15 - 17:30
        new HoraDia { Id = 35, DiaId = 2, HoraId = 26 }, // 16.00 - 17:30
        new HoraDia { Id = 36, DiaId = 2, HoraId = 10 }, // 16.00 - 18.15
        new HoraDia { Id = 37, DiaId = 2, HoraId = 27 }, // 16.45 - 18.15
        new HoraDia { Id = 38, DiaId = 2, HoraId = 18 }, // 17:30 - 19:00
        new HoraDia { Id = 39, DiaId = 2, HoraId = 28 }, // 18.15 - 19.45
        new HoraDia { Id = 40, DiaId = 2, HoraId = 11 }, // 18.15 - 20.30
        new HoraDia { Id = 41, DiaId = 2, HoraId = 20 }, // 19:00 - 20:30
        new HoraDia { Id = 42, DiaId = 2, HoraId = 19 }, // 19:00 - 21:15
        new HoraDia { Id = 43, DiaId = 2, HoraId = 31 }, // 20.30 - 22.00
        new HoraDia { Id = 44, DiaId = 2, HoraId = 12 }, // 20.30 - 22.45
        new HoraDia { Id = 45, DiaId = 2, HoraId = 30 }, // 21.15 - 22:45

        // MIERCOLES
        new HoraDia { Id = 46, DiaId = 3, HoraId = 7 }, // 7.00 - 9.15
        new HoraDia { Id = 47, DiaId = 3, HoraId = 1 }, // 7.00 - 8.30
        new HoraDia { Id = 48, DiaId = 3, HoraId = 2 }, // 8.30 - 10.00
        new HoraDia { Id = 49, DiaId = 3, HoraId = 8 }, // 9.15 - 11.30
        new HoraDia { Id = 50, DiaId = 3, HoraId = 3 }, // 10.00 - 11.30
        new HoraDia { Id = 51, DiaId = 3, HoraId = 4 }, // 11.30 - 13.00
        new HoraDia { Id = 52, DiaId = 3, HoraId = 14 }, // 11:30 - 13:45
        new HoraDia { Id = 53, DiaId = 3, HoraId = 32 }, // 12.15 - 13.45
        new HoraDia { Id = 54, DiaId = 3, HoraId = 23 }, // 13:45 - 15:15
        new HoraDia { Id = 55, DiaId = 3, HoraId = 15 }, // 13:45 - 16:00
        new HoraDia { Id = 56, DiaId = 3, HoraId = 6 }, // 14.30 - 16.00
        new HoraDia { Id = 57, DiaId = 3, HoraId = 25 }, // 15.15 - 16:45
        new HoraDia { Id = 58, DiaId = 3, HoraId = 10 }, // 16.00 - 18.15
        new HoraDia { Id = 59, DiaId = 3, HoraId = 27 }, // 16.45 - 18.15
        new HoraDia { Id = 60, DiaId = 3, HoraId = 26 }, // 16.00 - 17:30
        new HoraDia { Id = 61, DiaId = 3, HoraId = 28 }, // 18.15 - 19.45
        new HoraDia { Id = 62, DiaId = 3, HoraId = 20 }, // 19:00 - 20:30
        new HoraDia { Id = 63, DiaId = 3, HoraId = 29 }, // 19.45 - 21.15
        new HoraDia { Id = 64, DiaId = 3, HoraId = 31 }, // 20.30 - 22.00
        new HoraDia { Id = 65, DiaId = 3, HoraId = 30 }, // 21.15 - 22:45

        

        // JUEVES
        new HoraDia { Id = 66, DiaId = 4, HoraId = 1 }, // 7.00 - 8.30
        new HoraDia { Id = 67, DiaId = 4, HoraId = 7 }, // 7.00 - 9.15
        new HoraDia { Id = 68, DiaId = 4, HoraId = 8 }, // 9.15 - 11.30
        new HoraDia { Id = 69, DiaId = 4, HoraId = 22 },  // 10:45 - 13:00 
        new HoraDia { Id = 70, DiaId = 4, HoraId = 14 }, // 11:30 - 13:45
        new HoraDia { Id = 71, DiaId = 4, HoraId = 24 }, // 13:00 - 15:15
        new HoraDia { Id = 72, DiaId = 4, HoraId = 15 }, // 13:45 - 16:00
        new HoraDia { Id = 73, DiaId = 4, HoraId = 17 }, // 15:15 - 17:30
        new HoraDia { Id = 74, DiaId = 4, HoraId = 25 }, // 15.15 - 16:45
        new HoraDia { Id = 75, DiaId = 4, HoraId = 26 }, // 16.00 - 17:30
        new HoraDia { Id = 76, DiaId = 4, HoraId = 10 }, // 16.00 - 18.15
        new HoraDia { Id = 77, DiaId = 4, HoraId = 18 }, // 17:30 - 19:00
        new HoraDia { Id = 78, DiaId = 4, HoraId = 28 }, // 18.15 - 19.45
        new HoraDia { Id = 79, DiaId = 4, HoraId = 11 }, // 18.15 - 20.30
        new HoraDia { Id = 80, DiaId = 4, HoraId = 20 }, // 19:00 - 20:30
        new HoraDia { Id = 81, DiaId = 4, HoraId = 19 }, // 19:00 - 21:15
        new HoraDia { Id = 82, DiaId = 4, HoraId = 31 }, // 20.30 - 22.00
        new HoraDia { Id = 83, DiaId = 4, HoraId = 12 },  // 20.30 - 22.45
        new HoraDia { Id = 84, DiaId = 4, HoraId = 30 }, // 21.15 - 22:45


        // VIERNES
        new HoraDia { Id = 85, DiaId = 5, HoraId = 1 }, // 7.00 - 8.30
        new HoraDia { Id = 86, DiaId = 5, HoraId = 7 }, // 7.00 - 9.15
        new HoraDia { Id = 87, DiaId = 5, HoraId = 2 }, // 8.30 - 10.00
        new HoraDia { Id = 88, DiaId = 5, HoraId = 8 }, // 9.15 - 11.30
        new HoraDia { Id = 89, DiaId = 5, HoraId = 3 }, // 10.00 - 11.30
        new HoraDia { Id = 90, DiaId = 5, HoraId = 13 }, // 10:00 - 12:15
        new HoraDia { Id = 91, DiaId = 3, HoraId = 4 }, // 11.30 - 13.00
        new HoraDia { Id = 92, DiaId = 5, HoraId = 14 }, // 11:30 - 13:45
        new HoraDia { Id = 93, DiaId = 5, HoraId = 32 }, // 12.15 - 13.45
        new HoraDia { Id = 94, DiaId = 5, HoraId = 15 }, // 13:45 - 16:00
        new HoraDia { Id = 95, DiaId = 5, HoraId = 23 }, // 13:45 - 15:15
        new HoraDia { Id = 96, DiaId = 5, HoraId = 25 }, // 15.15 - 16:45
        new HoraDia { Id = 97, DiaId = 5, HoraId = 26 }, // 16.00 - 17:30
        new HoraDia { Id = 98, DiaId = 5, HoraId = 27 }, // 16.45 - 18.15
        new HoraDia { Id = 99, DiaId = 5, HoraId = 38 }, // 18.15 - 21.15
        new HoraDia { Id = 100, DiaId = 5, HoraId = 28 }, // 18.15 - 19.45
        new HoraDia { Id = 101, DiaId = 5, HoraId = 20 }, // 19:00 - 20:30
        new HoraDia { Id = 102, DiaId = 5, HoraId = 21 }, // 19:45 - 22:00
        new HoraDia { Id = 103, DiaId = 5, HoraId = 29 }, // 19.45 - 21.15
        new HoraDia { Id = 104, DiaId = 5, HoraId = 31 }, // 20.30 - 22.00
        new HoraDia { Id = 105, DiaId = 5, HoraId = 30 }, // 21.15 - 22:45

        
        // SABADO 
        new HoraDia { Id = 106, DiaId = 6, HoraId = 1 }, // 7.00 - 8.30 -- SABADO
        new HoraDia { Id = 107, DiaId = 6, HoraId = 2 }, // 8.30 - 10.00 -- SABADO
        new HoraDia { Id = 108, DiaId = 6, HoraId = 35 }, // 8.30 - 11.30 -- SABADO
        new HoraDia { Id = 109, DiaId = 6, HoraId = 34 }, // 09.15 - 10.45 -- SABADO
        new HoraDia { Id = 110, DiaId = 6, HoraId = 13 }, // 10:00 - 12:15 -- SABADO
        new HoraDia { Id = 111, DiaId = 6, HoraId = 25 }, // 15.15 - 16:45
        new HoraDia { Id = 112, DiaId = 6, HoraId = 28 }, // 18.15 - 19.45 -- SABADO
        new HoraDia { Id = 113, DiaId = 6, HoraId = 33 }, // 18.26 - 19.45 -- SABADO

        
        new HoraDia { Id = 114, DiaId = 3, HoraId = 22 },  // 10:45 - 13:00 
        new HoraDia { Id = 115, DiaId = 5, HoraId = 22 },  // 10:45 - 13:00 
        new HoraDia { Id = 116, DiaId = 3, HoraId = 21 } // 19:45 - 22:00
    );
  }
}
