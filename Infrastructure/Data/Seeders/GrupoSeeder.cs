using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GrupoSeeder : IEntityTypeConfiguration<Grupo>
{
  public void Configure(EntityTypeBuilder<Grupo> builder)
  {
    builder.HasData(
        new Grupo { ID = 1, NOMBRE = "SA" },
        new Grupo { ID = 2, NOMBRE = "SB" },
        new Grupo { ID = 3, NOMBRE = "SC" },
        new Grupo { ID = 4, NOMBRE = "SD" },
        new Grupo { ID = 5, NOMBRE = "SE" },
        new Grupo { ID = 6, NOMBRE = "SF" },
        new Grupo { ID = 7, NOMBRE = "SG" },
        new Grupo { ID = 8, NOMBRE = "SH" },
        new Grupo { ID = 9, NOMBRE = "SI" },
        new Grupo { ID = 10, NOMBRE = "SK" },
        new Grupo { ID = 11, NOMBRE = "SN" },
        new Grupo { ID = 12, NOMBRE = "SM" },
        new Grupo { ID = 13, NOMBRE = "SP" },
        new Grupo { ID = 14, NOMBRE = "SR" },
        new Grupo { ID = 15, NOMBRE = "SS" },

        new Grupo { ID = 16, NOMBRE = "SX" },
        new Grupo { ID = 17, NOMBRE = "SZ" },

        new Grupo { ID = 18, NOMBRE = "F1" },
        new Grupo { ID = 19, NOMBRE = "BI" },
        new Grupo { ID = 20, NOMBRE = "CI" },
        new Grupo { ID = 21, NOMBRE = "C1" },
        new Grupo { ID = 22, NOMBRE = "I2" },
        new Grupo { ID = 23, NOMBRE = "ER" },
        new Grupo { ID = 24, NOMBRE = "R1" },
        new Grupo { ID = 25, NOMBRE = "1I" },
        new Grupo { ID = 26, NOMBRE = "I1" },
        new Grupo { ID = 27, NOMBRE = "NW" },
        new Grupo { ID = 28, NOMBRE = "NX" },

        new Grupo { ID = 29, NOMBRE = "W1" },

        new Grupo { ID = 30, NOMBRE = "X2" },
        new Grupo { ID = 31, NOMBRE = "X3" },
        new Grupo { ID = 32, NOMBRE = "X4" },

        new Grupo { ID = 33, NOMBRE = "Z1" },
        new Grupo { ID = 34, NOMBRE = "Z2" },
        new Grupo { ID = 35, NOMBRE = "Z3" },
        new Grupo { ID = 36, NOMBRE = "Z4" },
        new Grupo { ID = 37, NOMBRE = "Z5" },
        new Grupo { ID = 38, NOMBRE = "Z6" }
    );
  }
}
