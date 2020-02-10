using Aplicacion_de_eventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_de_eventos.Servicios
{
    public class ConstruirRespuestaEvento : IConstruirRespuestaEvento
    {

        public string ConstruirInfoEvento(List<IEvento> eventos)
        {
            StringBuilder respuesta = new StringBuilder();

            foreach (IEvento evento in eventos)
            {
                respuesta.Append($"El evento: {evento.Nombre} { evento.Estatus} en {evento.CantidadTiempo} {evento.UnidadTiempo}.");
            }

            return respuesta.ToString().Replace(".", Environment.NewLine);
        }
    }
}
