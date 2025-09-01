using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Carrera
{
    public sealed record class CarreraDeleteDto
    {
        [Required]
        public int Id { get; init; }
    }
}