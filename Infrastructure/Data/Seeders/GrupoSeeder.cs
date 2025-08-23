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
        new Grupo { ID = 3, NOMBRE = "SC" }
    );
  }
}
