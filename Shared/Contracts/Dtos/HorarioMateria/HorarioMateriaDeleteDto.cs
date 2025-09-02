// Shared/Contracts/Dtos/Dias/DiaDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HorarioMateria
{
    public sealed record class HorarioMateriaDeleteDto
    {
        public int Id { get; init; }
    }
}
