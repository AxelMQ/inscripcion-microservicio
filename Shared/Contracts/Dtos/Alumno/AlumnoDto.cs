namespace Shared.Contracts.Dtos.Alumno
{

    public sealed record class AlumnoDto
    {
        public int Id { get; init; }
        public string? Nombre { get; init; }
        public decimal Ppa { get; init; }
        public int Telefono { get; init; }
        public int Registro { get; init; }
    }
}
