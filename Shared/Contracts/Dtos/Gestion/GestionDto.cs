// Shared/Contracts/Dtos/Gestiones/GestionDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Gestion
{
    public abstract record class GestionBaseDto
    {
        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public string? Nombre { get; init; }
    }

    public sealed record class GestionCreateDto : GestionBaseDto;

    public sealed record class GestionUpdateDto : GestionBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class GestionDeleteDto
    {
        public int Id { get; init; }
    }
}
