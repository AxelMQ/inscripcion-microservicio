// Shared/Contracts/Dtos/Carreras/CarreraDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Carrera
{
    public sealed record class CarreraCreateDto
    {
        [Required]
        [StringLength(10)]
        public string? Codigo { get; init; }

        [Required]
        [Range(0, 2)] // Asume que los valores de modalidad son 0, 1 o 2
        public short Modalidad { get; init; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; init; }
    }
}
