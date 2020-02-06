using System;

namespace Aplicacion_de_eventos.Interfaces
{
    public interface IEvento
    {
        string Nombre { get; set; }
        DateTime Fecha { get; set; }
        string Tiempo { get; set; }
    }
}
