using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class AlumnoSeeder : IEntityTypeConfiguration<Alumno>
{
  public void Configure(EntityTypeBuilder<Alumno> builder)
  {
    builder.HasData(
        new Alumno { Id = 1, Nombre = "Matias", Ppa = 0, Telefono = 7000000, Registro = 1000000 },
        new Alumno { Id = 2, Nombre = "Axel", Ppa = 0, Telefono = 7000001, Registro = 1000001 },
        new Alumno { Id = 3, Nombre = "Franco", Ppa = 0, Telefono = 7000002, Registro = 1000002 },
        new Alumno { Id = 4, Nombre = "Luis", Ppa = 0, Telefono = 7000003, Registro = 1000003 }
        );
  }
}
