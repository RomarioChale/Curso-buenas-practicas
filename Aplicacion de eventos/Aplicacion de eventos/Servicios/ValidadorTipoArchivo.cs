namespace Aplicacion_de_eventos.Servicios
{
    public class ValidadorTipoArchivo : IValidadorTipoArchivo
    {
        public string ValidarTipoArchivo(TipoArchivo tipo)
        {
            string tipoArchivo = string.Empty;

            switch (tipo)
            {
                case TipoArchivo.Txt:
                    tipoArchivo = "txt";
                    break;
                case TipoArchivo.Json:
                    tipoArchivo = "Json";
                    break;
            }
            return tipoArchivo;
        }
    }
}
