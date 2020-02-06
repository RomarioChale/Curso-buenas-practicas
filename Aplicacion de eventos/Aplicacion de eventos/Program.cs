using System;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion_de_eventos
{
    class AplicacionDeEventos
    {
        //readonly string archivo = @"C:\Users\edwin.chale\Desktop\Eventos.txt";
        readonly string archivo = Path.GetFullPath("Eventos.txt");

        string tiempo;
        readonly char[] charSeparators = new char[] { ',' };
        readonly DateTime fechaActual = DateTime.Now;
        readonly List<string> list = new List<string>();

        public void Leer()
        {
            string evento;
            DateTime fecha;
            string[] datos;
            string[] lines = System.IO.File.ReadAllLines(archivo);

            foreach (string line in lines)
            {

                datos = line.Split(charSeparators);

                evento = datos[0];
                fecha = Convert.ToDateTime(datos[1]);

                Calcular(evento, fecha);
               
            }
            foreach (var items in list)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();


        }

        public void Calcular(string evento, DateTime fecha)
        {
            double horas = (fecha - fechaActual).TotalHours;
            VerificarTiempo(horas);

            if (fecha < fechaActual)
            {
                list.Add("El evento "+ evento + " ocurrió hace " + tiempo);
            }
            else
            {
                list.Add("El evento " + evento + " ocurrirá en " + tiempo);
            }
            
        }

        public string VerificarTiempo(double horas)
        {
            double minutos;
            double cantidad;

            minutos = horas * 60;
            tiempo = Math.Round(minutos) + " minutos";
            if (horas > 1 && horas <  24)
            {
                tiempo = Math.Round(horas)  + " horas";
            }
            if (horas > 24 && horas < 730)
            {
                cantidad = horas / 24;
                tiempo = Math.Round(cantidad) + " días";
            }
            if(horas  > 730)
            {
                cantidad = horas / 730;

                tiempo = (Math.Round(cantidad)+1) + " Meses";
            }

           
            return tiempo;
        }

        static void Main(string[] args)
        {
            AplicacionDeEventos program = new AplicacionDeEventos();
            program.Leer();
            Console.ReadLine();

        }
    }
}
