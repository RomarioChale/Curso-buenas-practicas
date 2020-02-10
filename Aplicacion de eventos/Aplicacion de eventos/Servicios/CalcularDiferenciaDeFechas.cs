using Aplicacion_de_eventos.Interfaces;
using System;

namespace Aplicacion_de_eventos.Servicios
{
    public class CalcularDiferenciaDeFechas : ICalcularDiferenciaDeFechas
    {
        public double DirerenciaFechaActualYFechaEvento(DateTime fecha, DateTime fechaActual)
        {
            double horas = (fecha - fechaActual).TotalHours;

            return horas;
        }

       

        
    }
}
