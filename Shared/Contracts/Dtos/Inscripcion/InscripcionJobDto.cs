namespace Shared.Contracts.Dtos.Inscripcion
{
    public class InscripcionJobDto
    {
        public InscripcionCreateDto Dto { get; set; } = default!;
        public string IdempotencyKey { get; set; } = default!;
    }
}
