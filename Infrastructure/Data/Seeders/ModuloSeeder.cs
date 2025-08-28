using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class ModuloSeeder : IEntityTypeConfiguration<Modulo>
{
  public void Configure(EntityTypeBuilder<Modulo> builder)
  {
    builder.HasData(
        new Modulo { Id = 1, NroModulo = 236 },
        new Modulo { Id = 2, NroModulo = 225 },
        new Modulo { Id = 3, NroModulo = 260 },
        new Modulo { Id = 4, NroModulo = 224 },
        new Modulo { Id = 5, NroModulo = 256 },
        new Modulo { Id = 6, NroModulo = 222 }
    );
  }
}
