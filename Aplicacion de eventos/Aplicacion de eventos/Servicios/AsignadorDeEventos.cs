using Aplicacion_de_eventos.Interfaces;
using System;
using System.Collections.Generic;

namespace Aplicacion_de_eventos.Servicios
{
    public class AsignadorDeEventos : IAsignadorDeEventos
    {

        public List<IEvento> AsignarDatosDeArchivos(string[] lines)
        {
            string[] datos;
            char[] charSeparators = new char[] { ',' };
            try
            {
                List<IEvento> eventos = new List<IEvento>();

                foreach (string line in lines)
                {
                    datos = line.Split(charSeparators);

                    Evento evento = new Evento()
                    {
                        Nombre = datos[0],
                        Fecha = Convert.ToDateTime(datos[1])
                    };

                    eventos.Add(evento);
                }
                return eventos;
            }
            catch (Exception ex)
            {
                Exception exception = new Exception(ex.Message);
                throw exception;
            }


        }
    }
}
