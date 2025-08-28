// Api/Dtos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Materia
{
  public abstract record class MateriaBaseDto
  {
    public short Credito { get; init; }
    public bool EsElectiva { get; init; }
    public string? Nombre { get; init; }
    public string? Sigla { get; init; }
  }

  public sealed record class MateriaCreateDto : MateriaBaseDto;

  public sealed record class MateriaUpdateDto : MateriaBaseDto
  {
    public int Id { get; init; }
  }

  public sealed record class MateriaDeleteDto
  {
    public int Id { get; init; }
  }

}
