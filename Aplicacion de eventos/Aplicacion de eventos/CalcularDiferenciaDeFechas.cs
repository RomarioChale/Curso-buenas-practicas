using Aplicacion_de_eventos.Interfaces;
using System;

namespace Aplicacion_de_eventos
{
    public class CalcularDiferenciaDeFechas : ICalcularDiferenciaDeFechas
    {
        public double CalcularDiferencia(DateTime fecha)
        {
            double horas = (fecha - DateTime.Now).TotalHours;

            return horas;
        }

        public string ValidarFecha(IEvento evento)
        {

            string respuesta;
            if (evento.Fecha < DateTime.Now)
            {
                respuesta = "El evento " + evento.Nombre + " ocurrió hace " + evento.Tiempo;
            }
            else
            {
                respuesta = "El evento " + evento.Nombre + " ocurrirá en " + evento.Tiempo;
            }

            return respuesta;

        }

        public string EvaluarFecha(double tiempo)
        {
            double minutos;
            double cantidad;
            string respuesta;

            minutos = tiempo * 60;
            respuesta = Math.Round(minutos) + " minutos";
            if (tiempo > 1 && tiempo < 24)
            {
                respuesta = Math.Round(tiempo) + " horas";
            }
            if (tiempo > 24 && tiempo < 730)
            {
                cantidad = tiempo / 24;
                respuesta = Math.Round(cantidad) + " días";
            }
            if (tiempo > 730)
            {
                cantidad = tiempo / 730;

                respuesta = (Math.Round(cantidad) + 1) + " Meses";
            }


            return respuesta;
        }
    }
}
