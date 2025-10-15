using System;

namespace Domain.Exceptions
{
    public class NoSeatsAvailableException : Exception
    {
        public int? HorarioMateriaId { get; }

        public NoSeatsAvailableException() : base("No hay cupos disponibles para la materia solicitada")
        {
        }

        public NoSeatsAvailableException(string message) : base(message)
        {
        }

        public NoSeatsAvailableException(int horarioMateriaId) 
            : base($"No hay cupos disponibles para el horario de materia con ID: {horarioMateriaId}")
        {
            HorarioMateriaId = horarioMateriaId;
        }

        public NoSeatsAvailableException(int horarioMateriaId, string message) 
            : base(message)
        {
            HorarioMateriaId = horarioMateriaId;
        }

        public NoSeatsAvailableException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        public NoSeatsAvailableException(int horarioMateriaId, string message, Exception innerException) 
            : base(message, innerException)
        {
            HorarioMateriaId = horarioMateriaId;
        }
    }
}

