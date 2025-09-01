using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Nivel
{
    public sealed record class NivelUpdateDto
    {
        [Required]
        public int Id { get; init; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; init; }

        [Required]
        [Range(1, short.MaxValue, ErrorMessage = "El orden debe ser un número positivo.")]
        public short Orden { get; init; }
    }
}
