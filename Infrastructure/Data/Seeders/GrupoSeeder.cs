using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GrupoSeeder : IEntityTypeConfiguration<Grupo>
{
  public void Configure(EntityTypeBuilder<Grupo> builder)
  {
    builder.HasData(
        new Grupo { Id = 1, Nombre = "SA" },
        new Grupo { Id = 2, Nombre = "SB" },
        new Grupo { Id = 3, Nombre = "SC" },
        new Grupo { Id = 4, Nombre = "SD" },
        new Grupo { Id = 5, Nombre = "SE" },
        new Grupo { Id = 6, Nombre = "SF" },
        new Grupo { Id = 7, Nombre = "SG" },
        new Grupo { Id = 8, Nombre = "SH" },
        new Grupo { Id = 9, Nombre = "SI" },
        new Grupo { Id = 10, Nombre = "SK" },
        new Grupo { Id = 11, Nombre = "SN" },
        new Grupo { Id = 12, Nombre = "SM" },
        new Grupo { Id = 13, Nombre = "SP" },
        new Grupo { Id = 14, Nombre = "SR" },
        new Grupo { Id = 15, Nombre = "SS" },

        new Grupo { Id = 16, Nombre = "SX" },
        new Grupo { Id = 17, Nombre = "SZ" },

        new Grupo { Id = 18, Nombre = "F1" },
        new Grupo { Id = 19, Nombre = "BI" },
        new Grupo { Id = 20, Nombre = "CI" },
        new Grupo { Id = 21, Nombre = "C1" },
        new Grupo { Id = 22, Nombre = "I2" },
        new Grupo { Id = 23, Nombre = "ER" },
        new Grupo { Id = 24, Nombre = "R1" },
        new Grupo { Id = 25, Nombre = "1I" },
        new Grupo { Id = 26, Nombre = "I1" },
        new Grupo { Id = 27, Nombre = "NW" },
        new Grupo { Id = 28, Nombre = "NX" },

        new Grupo { Id = 29, Nombre = "W1" },

        new Grupo { Id = 30, Nombre = "X2" },
        new Grupo { Id = 31, Nombre = "X3" },
        new Grupo { Id = 32, Nombre = "X4" },

        new Grupo { Id = 33, Nombre = "Z1" },
        new Grupo { Id = 34, Nombre = "Z2" },
        new Grupo { Id = 35, Nombre = "Z3" },
        new Grupo { Id = 36, Nombre = "Z4" },
        new Grupo { Id = 37, Nombre = "Z5" },
        new Grupo { Id = 38, Nombre = "Z6" }
    );
  }
}
