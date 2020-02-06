using System;

namespace Aplicacion_de_eventos.Interfaces
{
    public interface IAccionesDeFechas
    {
        double CalcularDiferencia(DateTime fecha);

        string ValidarVerboPorFecha(IEvento evento);

        string EvaluarTiempo(double tiempo);
    }
}
