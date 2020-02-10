using Aplicacion_de_eventos.Servicios.Interfaces;
using System.IO;

namespace Aplicacion_de_eventos.Servicios
{
    public class BuscadorDeArchivos: IBuscadorDeArchivos
    {
        private readonly IValidadorTipoArchivo _validadorTipoArchivo;
        public BuscadorDeArchivos(IValidadorTipoArchivo validadorTipoArchivo)
        {
            _validadorTipoArchivo = validadorTipoArchivo;
        }
        public string BuscarArchivo(string nombreArchivo, TipoArchivo tipo)
        {
            string extecion = _validadorTipoArchivo.ValidarTipoArchivo(tipo);
            string archivo;

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                archivo = Path.GetFullPath("Eventos" + "." + extecion);
            }
            else
            {
                archivo = Path.GetFullPath(nombreArchivo + "." + extecion);
            }

            return archivo;
         }

     
    }
}
