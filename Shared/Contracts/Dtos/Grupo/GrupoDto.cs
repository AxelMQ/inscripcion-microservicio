// Shared/Contracts/Dtos/Grupos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Grupo
{
    public abstract record class GrupoBaseDto
    {
        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public string? Nombre { get; init; }
    }

    public sealed record class GrupoCreateDto : GrupoBaseDto;

    public sealed record class GrupoUpdateDto : GrupoBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class GrupoDeleteDto
    {
        public int Id { get; init; }
    }
}
