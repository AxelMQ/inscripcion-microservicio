using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Docente
{
    public sealed record class DocenteUpdateDto
    {
        [Required]
        [StringLength(100)]
        public string? Nombre { get; init; }

        [Phone]
        public long? Telefono { get; init; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El CI debe ser un número positivo.")]
        public int Ci { get; init; }
    }

}
