using System;

namespace Domain.Exceptions
{
    public class HorarioMateriaNotFoundException : Exception
    {
        public int HorarioMateriaId { get; }

        public HorarioMateriaNotFoundException(int horarioMateriaId) 
            : base($"No se encontró el horario de materia con ID: {horarioMateriaId}")
        {
            HorarioMateriaId = horarioMateriaId;
        }

        public HorarioMateriaNotFoundException(int horarioMateriaId, string message) 
            : base(message)
        {
            HorarioMateriaId = horarioMateriaId;
        }

        public HorarioMateriaNotFoundException(int horarioMateriaId, string message, Exception innerException) 
            : base(message, innerException)
        {
            HorarioMateriaId = horarioMateriaId;
        }
    }
}

