using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class PlanEstudioSeeder : IEntityTypeConfiguration<PlanEstudio>
{
    public void Configure(EntityTypeBuilder<PlanEstudio> builder)
    {
        builder.HasData(
            new PlanEstudio { ID = 1, CODIGO = "ING-INF", CARRERA_ID = 2 },
            new PlanEstudio { ID = 2, CODIGO = "ING-SIS", CARRERA_ID = 3 },
            new PlanEstudio { ID = 3, CODIGO = "ING-RED", CARRERA_ID = 1 },
            new PlanEstudio { ID = 4, CODIGO = "ING-ROB", CARRERA_ID = 4 }
        );
    }
}
