using Aplicacion_de_eventos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion_de_eventos
{
    class AplicacionDeEventos
    {
        private readonly ICalcularDiferenciaDeFechas _calcularDifernciaDeFechas;
        private readonly IGuardarEvento _GuardarEvento;

        private readonly List<string> respuesta = new List<string>();
        private readonly string archivo = Path.GetFullPath("Eventos.txt");
        private readonly char[] charSeparators = new char[] { ',' };


        public AplicacionDeEventos(
            ICalcularDiferenciaDeFechas calcularDifernciaDeFechas,
            IGuardarEvento guardarEvento)
        {
            _calcularDifernciaDeFechas = calcularDifernciaDeFechas;
            _GuardarEvento = guardarEvento;
        }

        public void Action()
        {
            string[] lines = System.IO.File.ReadAllLines(archivo);
            string[] datos;

            foreach (string line in lines)
            {

                datos = line.Split(charSeparators);
                string evento = datos[0];
                DateTime fecha = Convert.ToDateTime(datos[1]);

               double horas = _calcularDifernciaDeFechas.CalcularDiferencia(fecha);
               string descripcion = _calcularDifernciaDeFechas.EvaluarFecha(Math.Abs(horas));
                IEvento EventoNuevo = _GuardarEvento.GuardarNuevoEvento(evento, fecha, descripcion);
                string dato = _calcularDifernciaDeFechas.ValidarFecha(EventoNuevo);
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
            GuardarEvento guardarEvento = new GuardarEvento();
            CalcularDiferenciaDeFechas calcularDiferenciaDeFechas = new CalcularDiferenciaDeFechas();
            AplicacionDeEventos program = new AplicacionDeEventos(
                calcularDiferenciaDeFechas,
                guardarEvento);
            program.Action();
            program.MostrarDatos();
            Console.ReadLine();

        }
    }
}
