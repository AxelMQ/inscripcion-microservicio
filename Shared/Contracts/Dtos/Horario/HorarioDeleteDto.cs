// Shared/Contracts/Dtos/Dias/DiaDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Horario
{
    public sealed record class HorarioDeleteDto
    {
        public int Id { get; init; }
    }
}
