// Shared/Contracts/Dtos/Grupos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Grupo
{
    public sealed record class GrupoCreateDto
    {
        [Required]
        [StringLength(50)]
        public string? Nombre { get; init; }
    }
}
