using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class DiaSeeder : IEntityTypeConfiguration<Dia>
{
  public void Configure(EntityTypeBuilder<Dia> builder)
  {
    builder.HasData(
        new Dia { ID = 1, NOMBRE = "LUNES" },
        new Dia { ID = 2, NOMBRE = "MARTES" },
        new Dia { ID = 3, NOMBRE = "MIERCOLES" },
        new Dia { ID = 4, NOMBRE = "JUEVES" },
        new Dia { ID = 5, NOMBRE = "VIERNES" },
        new Dia { ID = 6, NOMBRE = "SABADO" }
    );
  }
}
