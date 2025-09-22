using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Gestion
{
    public sealed record class GestionUpdateDto
    {
        [Required]
        [StringLength(20)]
        public string? Nombre { get; init; }
    }
}
