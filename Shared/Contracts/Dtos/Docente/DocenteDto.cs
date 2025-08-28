// Shared/Contracts/Dtos/Docentes/DocenteDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Docente
{
    public abstract record class DocenteBaseDto
    {
        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public string? Nombre { get; init; }

        public long? Telefono { get; init; }

        [Required(ErrorMessage = "El campo 'CI' es obligatorio.")]
        public int CI { get; init; }
    }

    public sealed record class DocenteCreateDto : DocenteBaseDto;

    public sealed record class DocenteUpdateDto : DocenteBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class DocenteDeleteDto
    {
        public int Id { get; init; }
    }
}
