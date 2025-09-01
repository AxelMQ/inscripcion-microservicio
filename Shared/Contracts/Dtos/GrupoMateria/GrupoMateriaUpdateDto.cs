
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.GrupoMateria
{
    public sealed record class GrupoMateriaUpdateDto
    {
        [Required]
        public int Id { get; init; }

        [Required]
        public int GrupoId { get; init; }

        [Required]
        public int MateriaId { get; init; }
    }
}
