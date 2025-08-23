using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GrupoMateriaSeeder : IEntityTypeConfiguration<GrupoMateria>
{
  public void Configure(EntityTypeBuilder<GrupoMateria> builder)
  {
    builder.HasData(
        new GrupoMateria { ID = 1, MATERIA_ID = 5, GRUPO_ID = 1 },
        new GrupoMateria { ID = 2, MATERIA_ID = 6, GRUPO_ID = 1 },
        new GrupoMateria { ID = 3, MATERIA_ID = 7, GRUPO_ID = 2 },
        new GrupoMateria { ID = 4, MATERIA_ID = 8, GRUPO_ID = 2 },
        new GrupoMateria { ID = 5, MATERIA_ID = 9, GRUPO_ID = 3 }
    );
  }
}
