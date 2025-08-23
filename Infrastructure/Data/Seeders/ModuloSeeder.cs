using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class ModuloSeeder : IEntityTypeConfiguration<Modulo>
{
  public void Configure(EntityTypeBuilder<Modulo> builder)
  {
    builder.HasData(
        new Modulo { ID = 1, NRO_MODULO = 236 },
        new Modulo { ID = 2, NRO_MODULO = 225 },
        new Modulo { ID = 3, NRO_MODULO = 260 },
        new Modulo { ID = 4, NRO_MODULO = 224 },
        new Modulo { ID = 5, NRO_MODULO = 256 },
        new Modulo { ID = 6, NRO_MODULO = 222 }
    );
  }
}
