using System.Collections.Generic;
using Aplicacion_de_eventos.Interfaces;

namespace Aplicacion_de_eventos.Servicios
{
    public interface IValidarTiempoDeEvento1
    {
        List<IEvento> EvaluarTiempoPorHoras(List<IEvento> eventos);
    }
}