
using System.ComponentModel.DataAnnotations;
namespace Shared.Contracts.Dtos.Materia
{
public sealed record class MateriaCreateDto
{
    [Required]
    public short Credito { get; init; }
    
    [Required]
    public bool EsElectiva { get; init; }
    
    [Required]
    [StringLength(60)]
    public string? Nombre { get; init; }
    
    [Required]
    [StringLength(10)]
    public string? Sigla { get; init; }
}
}
