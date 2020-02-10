using System.Collections.Generic;
using Aplicacion_de_eventos.Interfaces;

namespace Aplicacion_de_eventos.Servicios
{
    public interface IAsignadorDeEventos
    {
        List<IEvento> AsignarDatosDeArchivos(string[] lines);
    }
}