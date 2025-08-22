using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class CarreraSeeder : IEntityTypeConfiguration<Carrera>
{
    public void Configure(EntityTypeBuilder<Carrera> builder)
    {
        builder.HasData(
            new Carrera { ID = 1, CODIGO = "185", MODALIDAD = 0, NOMBRE = "INGENIERIA EN REDES Y TELECOMUNICACIONES" },
            new Carrera { ID = 2, CODIGO = "183", MODALIDAD = 0, NOMBRE = "INGENIERIA INFORMATICA" },
            new Carrera { ID = 3, CODIGO = "184", MODALIDAD = 0, NOMBRE = "INGENIERIA EN SISTEMAS" }
        );
    }
}
