using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Gestion
{
    public sealed record class GestionUpdateDto
    {
        [Required]
        public int Id { get; init; }

        [Required]
        [StringLength(20)]
        public string? Nombre { get; init; }
    }
}
