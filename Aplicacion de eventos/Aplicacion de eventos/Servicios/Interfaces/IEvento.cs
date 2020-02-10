using Aplicacion_de_eventos.Utilerias;
using System;

namespace Aplicacion_de_eventos.Interfaces
{
    public interface IEvento
    {
        string Nombre { get; set; }
        DateTime Fecha { get; set; }
        UnidadTiempo UnidadTiempo { get; set; }
        double CantidadTiempo { get; set; }
        Estatus Estatus { get; set; }
    }
}
