// Domain/Models/HoraDia.cs
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Models
{
  public class HoraDia : BaseEntity
  {
    public int DiaId { get; set; }
    public Dia Dia { get; set; } = null!;

    public int HoraId { get; set; }
    public Hora Hora { get; set; } = null!;

    public ICollection<HoraDiaHorario> HorasDiaHorario { get; set; } = new List<HoraDiaHorario>();
  }
}
