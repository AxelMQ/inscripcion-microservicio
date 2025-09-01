using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class DiaSeeder : IEntityTypeConfiguration<Dia>
{
  public void Configure(EntityTypeBuilder<Dia> builder)
  {
    builder.HasData(
        new Dia { Id = 1, Nombre = "LUNES" },
        new Dia { Id = 2, Nombre = "MARTES" },
        new Dia { Id = 3, Nombre = "MIERCOLES" },
        new Dia { Id = 4, Nombre = "JUEVES" },
        new Dia { Id = 5, Nombre = "VIERNES" },
        new Dia { Id = 6, Nombre = "SABADO" }
    );
  }
}
