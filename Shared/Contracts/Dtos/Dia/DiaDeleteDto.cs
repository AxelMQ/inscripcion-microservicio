// Shared/Contracts/Dtos/Dias/DiaDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Dia
{
    public sealed record class DiaDeleteDto
    {
        public int Id { get; init; }
    }
}
