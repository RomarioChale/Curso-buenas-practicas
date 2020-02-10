using Aplicacion_de_eventos.Servicios.Interfaces;
using System.IO;

namespace Aplicacion_de_eventos.Servicios
{
    public class LectorDeArchivos: ILectorDeArchivos
    {
        public string[] LeerArchivo(string ruta)
        {
            try
            {
                string[] lines = File.ReadAllLines(ruta);
                return lines;
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("Ocurrió un error con el archivo");
            }
        }
    }
}
