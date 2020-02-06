using Aplicacion_de_eventos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion_de_eventos
{
    class AplicacionDeEventos
    {
        private readonly IAccionesDeFechas _accionesDeFechas;
        private readonly IAccionesDeEvento _accionesDeEvento;

        private readonly List<string> respuesta = new List<string>();
        private readonly string archivo = Path.GetFullPath("Eventos.txt");
        private readonly char[] charSeparators = new char[] { ',' };


        public AplicacionDeEventos(
            IAccionesDeFechas calcularDifernciaDeFechas,
            IAccionesDeEvento guardarEvento)
        {
            _accionesDeFechas = calcularDifernciaDeFechas;
            _accionesDeEvento = guardarEvento;
        }

        public void Acciones()
        {
            string[] lines = System.IO.File.ReadAllLines(archivo);
            string[] datos;

            foreach (string line in lines)
            {
                datos = line.Split(charSeparators);
                string evento = datos[0];
                DateTime fecha = Convert.ToDateTime(datos[1]);

                double horas = _accionesDeFechas.CalcularDiferencia(fecha);
                string descripcion = _accionesDeFechas.EvaluarTiempo(Math.Abs(horas));
                IEvento eventoNuevo = _accionesDeEvento.GuardarNuevoEvento(evento, fecha, descripcion);
                string dato = _accionesDeFechas.ValidarVerboPorFecha(eventoNuevo);
                respuesta.Add(dato);
            }

        }

        public void MostrarDatos()
        {
            foreach (var item in respuesta)
            {
                Console.WriteLine(item);
            }

        }

        static void Main(string[] args)
        {
            AccionesDeEvento guardarEvento = new AccionesDeEvento();
            AccionesDeFechas calcularDiferenciaDeFechas = new AccionesDeFechas();
            AplicacionDeEventos program = new AplicacionDeEventos(
                calcularDiferenciaDeFechas,
                guardarEvento);
            program.Acciones();
            program.MostrarDatos();
            Console.ReadLine();

        }
    }
}
