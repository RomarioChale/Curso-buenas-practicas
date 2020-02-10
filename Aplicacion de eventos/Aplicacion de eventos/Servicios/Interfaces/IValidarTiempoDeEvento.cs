using Aplicacion_de_eventos.Interfaces;

namespace Aplicacion_de_eventos.Servicios.Interfaces
{
    public interface IValidarTiempoDeEvento
    {
        string ValidarTiempoPorFecha(IEvento evento);
        string EvaluarTiempoPorHoras(double horas);
    }
}
