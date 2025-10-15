using System;

namespace Domain.Exceptions
{
    public class AlumnoNotFoundException : Exception
    {
        public int AlumnoId { get; }

        public AlumnoNotFoundException(int alumnoId) 
            : base($"No se encontró el alumno con ID: {alumnoId}")
        {
            AlumnoId = alumnoId;
        }

        public AlumnoNotFoundException(int alumnoId, string message) 
            : base(message)
        {
            AlumnoId = alumnoId;
        }

        public AlumnoNotFoundException(int alumnoId, string message, Exception innerException) 
            : base(message, innerException)
        {
            AlumnoId = alumnoId;
        }
    }
}

