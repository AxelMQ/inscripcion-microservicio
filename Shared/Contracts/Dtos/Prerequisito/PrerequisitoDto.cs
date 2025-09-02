namespace Shared.Contracts.Dtos.Prerequisito
{
    public sealed record class PrerequisitoDto
    {
        public int MateriaPlanEstudioId { get; init; }
        public int RequisitoId { get; init; }

        // Propiedades simplificadas de la materia requisito
        public int RequisitoMateriaId { get; init; }
        public string RequisitoMateriaNombre { get; init; } = string.Empty;
        public string RequisitoMateriaSigla { get; init; } = string.Empty;
    }

}
