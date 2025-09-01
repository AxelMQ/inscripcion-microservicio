namespace Shared.Contracts.Dtos.Carrera
{
    public sealed record class CarreraDto
    {
        public int Id { get; init; }
        public string? Codigo { get; init; }
        public short Modalidad { get; init; }
        public string? Nombre { get; init; }
    }
}
