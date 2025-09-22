using System.ComponentModel.DataAnnotations;
namespace Shared.Contracts.Dtos.Prerequisito
{

    public sealed record class PrerequisitoUpdateDto
    {
        [Required]
        public int MateriaPlanEstudioId { get; init; }

        [Required]
        public int RequisitoId { get; init; }
    }
}
