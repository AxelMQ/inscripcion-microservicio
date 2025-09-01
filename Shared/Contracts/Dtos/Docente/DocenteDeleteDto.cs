using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Docente
{
    public sealed record class DocenteDeleteDto
    {
        [Required]
        public int Id { get; init; }
    }
}
