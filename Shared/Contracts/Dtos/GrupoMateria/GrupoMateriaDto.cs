using Shared.Contracts.Dtos.Grupo;
using Shared.Contracts.Dtos.Materia;
namespace Shared.Contracts.Dtos.GrupoMateria
{
    public sealed record class GrupoMateriaDto
    {
        public int Id { get; init; }
        public int GrupoId { get; init; }
        public GrupoDto? Grupo { get; init; }
        public int MateriaId { get; init; }
        public MateriaDto? Materia { get; init; }
    }
}
