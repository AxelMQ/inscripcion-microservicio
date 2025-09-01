using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class CarreraSeeder : IEntityTypeConfiguration<Carrera>
{
    public void Configure(EntityTypeBuilder<Carrera> builder)
    {
        builder.HasData(
            new Carrera { Id = 1, Codigo = "185", Modalidad = 0, Nombre = "INGENIERIA EN REDES Y TELECOMUNICACIONES" },
            new Carrera { Id = 2, Codigo = "183", Modalidad = 0, Nombre = "INGENIERIA INFORMATICA" },
            new Carrera { Id = 3, Codigo = "184", Modalidad = 0, Nombre = "INGENIERIA EN SISTEMAS" },
            new Carrera { Id = 4, Codigo = "323", Modalidad = 0, Nombre = "INGENIERIA ROBOTICA" }
        );
    }
}
