using System;

namespace Aplicacion_de_eventos.Interfaces
{
    public interface IAccionesDeEvento
    {
        IEvento GuardarNuevoEvento(string evento, DateTime fecha , string Tiempo );
    }
}
