using Aplicacion_de_eventos.Interfaces;
using System;

namespace Aplicacion_de_eventos
{
    public class GuardarEvento : IGuardarEvento
    {
        public IEvento GuardarNuevoEvento(string evento, DateTime fecha, string Tiempo)
        {
            Evento eventoNuevo = new Evento
            {
                Fecha = fecha,
                Nombre = evento,
                Tiempo = Tiempo
            };

            return eventoNuevo;
        }
    }
}
