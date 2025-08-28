// Shared/Contracts/Dtos/Dias/DiaDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Dia
{
    public abstract record class DiaBaseDto
    {
        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(63, ErrorMessage = "El campo 'Nombre' no puede tener más de 63 caracteres.")]
        public string? Nombre { get; init; }
    }

    public sealed record class DiaCreateDto : DiaBaseDto;

    public sealed record class DiaUpdateDto : DiaBaseDto
    {
        public int Id { get; init; }
    }

    public sealed record class DiaDeleteDto
    {
        public int Id { get; init; }
    }
}
