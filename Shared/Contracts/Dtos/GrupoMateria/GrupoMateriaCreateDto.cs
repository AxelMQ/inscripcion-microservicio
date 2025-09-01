using System.ComponentModel.DataAnnotations;
namespace Shared.Contracts.Dtos.GrupoMateria
{
    public sealed record class GrupoMateriaCreateDto
    {
        [Required]
        public int GrupoId { get; init; }

        [Required]
        public int MateriaId { get; init; }
    }
}
