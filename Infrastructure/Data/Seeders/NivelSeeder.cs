using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class NivelSeeder : IEntityTypeConfiguration<Nivel>
{
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.HasData(
            new Nivel { ID = 1, NOMBRE = "1 SEMESTRE" },
            new Nivel { ID = 2, NOMBRE = "2 SEMESTRE" },
            new Nivel { ID = 3, NOMBRE = "3 SEMESTRE" },
            new Nivel { ID = 4, NOMBRE = "4 SEMESTRE" },
            new Nivel { ID = 5, NOMBRE = "5 SEMESTRE" },
            new Nivel { ID = 6, NOMBRE = "6 SEMESTRE" },
            new Nivel { ID = 7, NOMBRE = "7 SEMESTRE" },
            new Nivel { ID = 8, NOMBRE = "8 SEMESTRE" },
            new Nivel { ID = 9, NOMBRE = "9 SEMESTRE" },
            new Nivel { ID = 10, NOMBRE = "10 SEMESTRE" }
        );
    }
}
