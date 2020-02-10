using Aplicacion_de_eventos.Interfaces;
using Aplicacion_de_eventos.Utilerias;
using System;

namespace Aplicacion_de_eventos
{
    public class Evento : IEvento
    {
       public string Nombre { get; set; }
       public DateTime Fecha { get; set; }
       public UnidadTiempo UnidadTiempo { get; set; }
       public double CantidadTiempo { get; set; }
       public Estatus Estatus { get; set; }
    }
}
