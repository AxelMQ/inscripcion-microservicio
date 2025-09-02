namespace Shared.Contracts.Dtos.Prerequisito
{
  public class RequisitoParaDto
  {
    public int MateriaPlanEstudioId { get; set; }
    public int RequisitoId { get; set; }
    public required string  MateriaQueRequiereNombre { get; set; }
    public required string MateriaQueRequiereSigla { get; set; }
  }
}