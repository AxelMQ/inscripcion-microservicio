// Shared/Contracts/Dtos/Dias/DiaDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Nivel
{
    public sealed record class NivelDeleteDto
    {
        [Required]
        public int Id { get; init; }
    }
}
