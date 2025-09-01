
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Carrera
{
    public sealed record class CarreraUpdateDto
    {
        [Required]
        public int Id { get; init; }

        [Required]
        [StringLength(10)]
        public string? Codigo { get; init; }

        [Required]
        [Range(0, 2)]
        public short Modalidad { get; init; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; init; }
    }
}
