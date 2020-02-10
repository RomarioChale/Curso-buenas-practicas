using Aplicacion_de_eventos.Interfaces;
using Aplicacion_de_eventos.Utilerias;
using System;
using System.Collections.Generic;

namespace Aplicacion_de_eventos.Servicios
{
    public class ValidarTiempoDeEvento : IValidarTiempoDeEvento1
    {
        private readonly DateTime _fechaActual = DateTime.Now;

        private readonly ICalcularDiferenciaDeFechas _calcularDiferenciaDeFechas;
        public ValidarTiempoDeEvento(ICalcularDiferenciaDeFechas calcularDiferenciaDeFechas)
        {
            _calcularDiferenciaDeFechas = calcularDiferenciaDeFechas;
        }


        public List<IEvento> EvaluarTiempoPorHoras(List<IEvento> eventos)
        {
            double minutos;
            double cantidad;

            List<IEvento> eventosFecha = new List<IEvento>();

            foreach (IEvento evento in eventos)
            {
                double horas = Math.Abs(_calcularDiferenciaDeFechas.DirerenciaFechaActualYFechaEvento(evento.Fecha, _fechaActual));

                minutos = horas * 60;

                evento.CantidadTiempo = Math.Round(minutos);
                evento.UnidadTiempo = UnidadTiempo.Minutos;
                evento.Estatus = evento.Fecha > _fechaActual ? Estatus.Ocurrirá : Estatus.Ocurrió;

                if (horas > 1 && horas < 24)
                {
                    evento.CantidadTiempo = Math.Round(horas);
                    evento.UnidadTiempo = UnidadTiempo.Horas;
                }
                if (horas > 24 && horas < 730)
                {
                    cantidad = horas / 24;
                    evento.CantidadTiempo = Math.Round(cantidad);
                    evento.UnidadTiempo = UnidadTiempo.Dias;
                }
                if (horas > 730)
                {
                    cantidad = horas / 730;

                    evento.CantidadTiempo = (Math.Round(cantidad) + 1);
                    evento.UnidadTiempo = UnidadTiempo.Meses;
                }

                eventosFecha.Add(evento);
            }

            return eventosFecha;
        }
    }
}
