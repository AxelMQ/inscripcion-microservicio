using Shared.Contracts.Dtos.Carrera;
namespace Shared.Contracts.Dtos.PlanEstudio
{
  public sealed record class PlanEstudioDto
  {
    public int Id { get; init; }
    public string? Codigo { get; init; }
    public int CarreraId { get; init; }
    public CarreraDto? Carrera { get; init; }
    //public ICollection<MateriaPlanEstudioDto> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudioDto>();
    // public ICollection<AlumnoPlanEstudioDto> AlumnoPlanEstudios { get; set; } = new List<AlumnoPlanEstudioDto>();
  }

}
