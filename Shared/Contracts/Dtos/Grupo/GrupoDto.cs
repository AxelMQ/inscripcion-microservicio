namespace Shared.Contracts.Dtos.Grupo
{
    public sealed record class GrupoDto
    {
        public int Id { get; init; }
        public string? Nombre { get; init; }
    }
}
