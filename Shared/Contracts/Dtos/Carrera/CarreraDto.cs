// Shared/Contracts/Dtos/Carreras/CarreraDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Carrera
{
    public abstract record class CarreraBaseDto
    {
        [Required(ErrorMessage = "El campo 'Codigo' es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo 'Codigo' no puede tener más de 10 caracteres.")]
        public string? Codigo { get; init; }

        [Required(ErrorMessage = "El campo 'MODALIDAD' es obligatorio.")]
        public short MODALIDAD { get; init; }

        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(63, ErrorMessage = "El campo 'Nombre' no puede tener más de 63 caracteres.")]
        public string? Nombre { get; init; }
    }

    public sealed record class CarreraCreateDto : CarreraBaseDto;

    public sealed record class CarreraUpdateDto : CarreraBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class CarreraDeleteDto
    {
        public int Id { get; init; }
    }
}
