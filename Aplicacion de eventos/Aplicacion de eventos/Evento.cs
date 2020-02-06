using Aplicacion_de_eventos.Interfaces;
using System;

namespace Aplicacion_de_eventos
{
    public class Evento : IEvento
    {
       public string Nombre { get; set; }
       public DateTime Fecha { get; set; }
       public string Tiempo { get; set; }
    }
}
