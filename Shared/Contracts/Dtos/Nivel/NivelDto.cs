// Shared/Contracts/Dtos/Niveles/NivelDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Nivel
{
    public abstract record class NivelBaseDto
    {
        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public string? Nombre { get; init; }

        [Required(ErrorMessage = "El campo 'Orden' es obligatorio.")]
        public short Orden { get; init; }
    }

    public sealed record class NivelCreateDto : NivelBaseDto;

    public sealed record class NivelUpdateDto : NivelBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class NivelDeleteDto
    {
        public int Id { get; init; }
    }
}
