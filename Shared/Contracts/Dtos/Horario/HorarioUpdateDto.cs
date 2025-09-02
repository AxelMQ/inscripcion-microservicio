using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Horario
{
    public sealed record class HorarioUpdateDto
    {
        [Required]
        public int Id { get; init; }
    }
}
