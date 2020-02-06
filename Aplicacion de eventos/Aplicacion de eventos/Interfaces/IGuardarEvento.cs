using System;

namespace Aplicacion_de_eventos.Interfaces
{
    public interface IGuardarEvento
    {
        IEvento GuardarNuevoEvento(string evento, DateTime fecha , string Tiempo );
    }
}
