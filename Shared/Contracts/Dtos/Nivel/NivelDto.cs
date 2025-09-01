
namespace Shared.Contracts.Dtos.Nivel
{
    public sealed record class NivelDto
    {
        public int Id { get; init; }
        public string? Nombre { get; init; }
        public short Orden { get; init; }
    }

}
