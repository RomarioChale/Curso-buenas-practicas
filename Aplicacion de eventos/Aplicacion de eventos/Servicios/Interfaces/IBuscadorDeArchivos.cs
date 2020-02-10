namespace Aplicacion_de_eventos.Servicios.Interfaces
{
    public interface IBuscadorDeArchivos
    {
        string BuscarArchivo(string nombreArchivo, TipoArchivo tipo);
    }
}
