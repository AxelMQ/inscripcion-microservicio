namespace Shared.Contracts.Dtos.Materia
{
public sealed record class MateriaDto
{
    public int Id { get; init; }
    public short Credito { get; init; }
    public bool EsElectiva { get; init; }
    public string? Nombre { get; init; }
    public string? Sigla { get; init; }
}
}
