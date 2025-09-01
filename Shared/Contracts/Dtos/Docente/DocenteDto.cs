namespace Shared.Contracts.Dtos.Docente
{
    public sealed record class DocenteDto
    {
        public int Id { get; init; }
        public string? Nombre { get; init; }
        public long? Telefono { get; init; }
        public int Ci { get; init; }
    }
}
