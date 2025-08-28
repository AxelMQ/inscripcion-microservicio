// Shared/Contracts/Dtos/Alumnos/AlumnoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Alumno
{
    public abstract record class AlumnoBaseDto
    {
        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public string? Nombre { get; init; }

        [Required(ErrorMessage = "El campo 'Ppa' es obligatorio.")]
        public decimal Ppa { get; init; }

        // Si quieres permitir null, cámbialo a int?
        public int Telefono { get; init; }

        [Required(ErrorMessage = "El campo 'Registro' es obligatorio.")]
        public int Registro { get; init; }
    }

    public sealed record class AlumnoCreateDto : AlumnoBaseDto;

    public sealed record class AlumnoUpdateDto : AlumnoBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class AlumnoDeleteDto
    {
        public int Id { get; init; }
    }
}
