// Shared/Contracts/Dtos/Dias/DiaDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Gestion
{
    public sealed record class GestionDeleteDto
    {
        [Required]
        public int Id { get; init; }
    }
}
