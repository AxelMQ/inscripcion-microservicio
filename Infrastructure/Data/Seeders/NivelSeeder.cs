using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class NivelSeeder : IEntityTypeConfiguration<Nivel>
{
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.HasData(
            new Nivel { Id = 1, Nombre = "1 SEMESTRE", Orden = 1 },
            new Nivel { Id = 2, Nombre = "2 SEMESTRE", Orden = 2 },
            new Nivel { Id = 3, Nombre = "3 SEMESTRE", Orden = 3 },
            new Nivel { Id = 4, Nombre = "4 SEMESTRE", Orden = 4 },
            new Nivel { Id = 5, Nombre = "5 SEMESTRE", Orden = 5 },
            new Nivel { Id = 6, Nombre = "6 SEMESTRE", Orden = 6 },
            new Nivel { Id = 7, Nombre = "7 SEMESTRE", Orden = 7 },
            new Nivel { Id = 8, Nombre = "8 SEMESTRE", Orden = 8 },
            new Nivel { Id = 9, Nombre = "9 SEMESTRE", Orden = 9 },
            new Nivel { Id = 10, Nombre = "10 SEMESTRE", Orden = 10 }
        );
    }
}
