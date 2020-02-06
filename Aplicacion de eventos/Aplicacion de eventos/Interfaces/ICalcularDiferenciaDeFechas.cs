using System;

namespace Aplicacion_de_eventos.Interfaces
{
    public interface ICalcularDiferenciaDeFechas
    {
        double CalcularDiferencia(DateTime fecha);

        string ValidarFecha(IEvento evento);

        string EvaluarFecha(double tiempo);
    }
}
