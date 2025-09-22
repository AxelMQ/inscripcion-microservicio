using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Grupo
{
    public sealed record class GrupoUpdateDto
    {
        [Required]
        [StringLength(50)]
        public string? Nombre { get; init; }
    }
}
