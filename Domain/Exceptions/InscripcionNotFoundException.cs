using System;

namespace Domain.Exceptions
{
    public class InscripcionNotFoundException : Exception
    {
        public int InscripcionId { get; }

        public InscripcionNotFoundException(int inscripcionId) 
            : base($"No se encontró la inscripción con ID: {inscripcionId}")
        {
            InscripcionId = inscripcionId;
        }

        public InscripcionNotFoundException(int inscripcionId, string message) 
            : base(message)
        {
            InscripcionId = inscripcionId;
        }

        public InscripcionNotFoundException(int inscripcionId, string message, Exception innerException) 
            : base(message, innerException)
        {
            InscripcionId = inscripcionId;
        }
    }
}

