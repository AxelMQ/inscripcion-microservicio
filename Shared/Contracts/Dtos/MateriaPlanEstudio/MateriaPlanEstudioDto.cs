using Shared.Contracts.Dtos.Materia;
using Shared.Contracts.Dtos.Nivel;
using Shared.Contracts.Dtos.PlanEstudio;
using Shared.Contracts.Dtos.Prerequisito;
namespace Shared.Contracts.Dtos.MateriaPlanEstudio
{
  public sealed record class MateriaPlanEstudioDto
  {
    public int Id { get; init; }
    //public int MateriaId { get; init; }
    public MateriaDto? Materia { get; init; }
    //public int NivelId { get; init; }
    public NivelDto? Nivel { get; init; }
    //public int PlanEstudioId { get; init; }
    public PlanEstudioDto? PlanEstudio { get; init; }

    // DTO para los requisitos de la materia (hacia adelante)
    public ICollection<PrerequisitoDto>? MateriasRequisito { get; set; }

    // NUEVO: DTO para las materias que la requieren (la relación inversa)
    public ICollection<RequisitoParaDto>? RequisitosPara { get; set; }
  }
}
