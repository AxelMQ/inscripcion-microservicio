using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GestionSeeder : IEntityTypeConfiguration<Gestion>
{
  public void Configure(EntityTypeBuilder<Gestion> builder)
  {
    builder.HasData(
      new Gestion { Id = 1, Nombre = "1/2025" },  
      new Gestion { Id = 2, Nombre = "2/2025" },
      new Gestion { Id = 3, Nombre = "3/2025" },
      new Gestion { Id = 4, Nombre = "4/2025" },
      new Gestion { Id = 5, Nombre = "1/2024" },
      new Gestion { Id = 6, Nombre = "2/2024" },
      new Gestion { Id = 7, Nombre = "3/2024" },
      new Gestion { Id = 8, Nombre = "4/2024" }
    );
  }
}
