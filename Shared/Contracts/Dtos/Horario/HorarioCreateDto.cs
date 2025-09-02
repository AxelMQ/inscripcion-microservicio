using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Horario
{
    public sealed record class HorarioCreateDto
    {
        public int Id { get; init; }
    }
}
