using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GestionSeeder : IEntityTypeConfiguration<Gestion>
{
  public void Configure(EntityTypeBuilder<Gestion> builder)
  {
    builder.HasData(
      new Gestion { ID = 1, NOMBRE = "1/2025" },  
      new Gestion { ID = 2, NOMBRE = "2/2025" },
      new Gestion { ID = 3, NOMBRE = "3/2025" },
      new Gestion { ID = 4, NOMBRE = "4/2025" },
      new Gestion { ID = 5, NOMBRE = "1/2024" },
      new Gestion { ID = 6, NOMBRE = "2/2024" },
      new Gestion { ID = 7, NOMBRE = "3/2024" },
      new Gestion { ID = 8, NOMBRE = "4/2024" }
    );
  }
}
