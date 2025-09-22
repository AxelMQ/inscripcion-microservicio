using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Dia
{
    public sealed record class DiaUpdateDto
    {
        [Required]
        [StringLength(20)]
        public string? Nombre { get; init; }
    }
}
