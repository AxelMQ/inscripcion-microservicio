using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HoraDiaSeeder : IEntityTypeConfiguration<HoraDia>
{
  public void Configure(EntityTypeBuilder<HoraDia> builder)
  {
    builder.HasData(
        new HoraDia { ID = 1, DIA_ID = 1, HORA_ID = 1 },
        new HoraDia { ID = 2, DIA_ID = 1, HORA_ID = 2 },
        new HoraDia { ID = 3, DIA_ID = 1, HORA_ID = 3 },
        new HoraDia { ID = 4, DIA_ID = 1, HORA_ID = 4 },
        new HoraDia { ID = 5, DIA_ID = 1, HORA_ID = 5 },

        new HoraDia { ID = 6, DIA_ID = 3, HORA_ID = 1 },
        new HoraDia { ID = 7, DIA_ID = 3, HORA_ID = 2 },
        new HoraDia { ID = 8, DIA_ID = 3, HORA_ID = 3 },
        new HoraDia { ID = 9, DIA_ID = 3, HORA_ID = 4 },
        new HoraDia { ID = 10, DIA_ID = 3, HORA_ID = 5 },

        new HoraDia { ID = 11, DIA_ID = 5, HORA_ID = 1 },
        new HoraDia { ID = 12, DIA_ID = 5, HORA_ID = 2 },
        new HoraDia { ID = 13, DIA_ID = 5, HORA_ID = 3 },
        new HoraDia { ID = 14, DIA_ID = 5, HORA_ID = 4 },
        new HoraDia { ID = 15, DIA_ID = 5, HORA_ID = 5 },

        new HoraDia { ID = 16, DIA_ID = 2, HORA_ID = 7 },
        new HoraDia { ID = 17, DIA_ID = 2, HORA_ID = 8 },
        new HoraDia { ID = 18, DIA_ID = 2, HORA_ID = 9 },
        new HoraDia { ID = 19, DIA_ID = 2, HORA_ID = 10 },
        new HoraDia { ID = 20, DIA_ID = 2, HORA_ID = 11 },
        new HoraDia { ID = 21, DIA_ID = 2, HORA_ID = 12 },

        new HoraDia { ID = 22, DIA_ID = 4, HORA_ID = 7 },
        new HoraDia { ID = 23, DIA_ID = 4, HORA_ID = 8 },
        new HoraDia { ID = 24, DIA_ID = 4, HORA_ID = 9 },
        new HoraDia { ID = 25, DIA_ID = 4, HORA_ID = 10 },
        new HoraDia { ID = 26, DIA_ID = 4, HORA_ID = 11 },
        new HoraDia { ID = 27, DIA_ID = 4, HORA_ID = 12 }

    );
  }
}
