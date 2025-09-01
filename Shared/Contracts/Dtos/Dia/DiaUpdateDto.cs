using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Dia
{
    public sealed record class DiaUpdateDto
    {
        [Required]
        public int Id { get; init; }

        [Required]
        [StringLength(20)]
        public string? Nombre { get; init; }
    }
}
