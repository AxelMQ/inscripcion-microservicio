using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class PlanEstudioSeeder : IEntityTypeConfiguration<PlanEstudio>
{
    public void Configure(EntityTypeBuilder<PlanEstudio> builder)
    {
        builder.HasData(
            new PlanEstudio { Id = 1, Codigo = "ING-INF", CarreraId = 2 },
            new PlanEstudio { Id = 2, Codigo = "ING-SIS", CarreraId = 3 },
            new PlanEstudio { Id = 3, Codigo = "ING-RED", CarreraId = 1 },
            new PlanEstudio { Id = 4, Codigo = "ING-ROB", CarreraId = 4 }
        );
    }
}
