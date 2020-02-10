using Aplicacion_de_eventos.Interfaces;
using Aplicacion_de_eventos.Servicios;
using System;
using System.Collections.Generic;

namespace Aplicacion_de_eventos
{
    public class AplicacionDeEventos
    {
        static void Main(string[] args)
        {
            ValidadorTipoArchivo tipoArchivo = new ValidadorTipoArchivo();
            BuscadorDeArchivos buscadorDeArchivos = new BuscadorDeArchivos(tipoArchivo);
            LectorDeArchivos lectorDeArchivos = new LectorDeArchivos();
            AsignadorDeEventos asignadorDeEventos = new AsignadorDeEventos();
            CalcularDiferenciaDeFechas calcularDiferenciaDeFechas = new CalcularDiferenciaDeFechas();
            ValidarTiempoDeEvento validarTiempoDeEvento = new ValidarTiempoDeEvento(calcularDiferenciaDeFechas);
            ConstruirRespuestaEvento construirRespuestaEvento = new ConstruirRespuestaEvento();


            string archivo = buscadorDeArchivos.BuscarArchivo("Eventos" , TipoArchivo.Txt);
            string[] datos = lectorDeArchivos.LeerArchivo(archivo);
            List<IEvento> eventos = asignadorDeEventos.AsignarDatosDeArchivos(datos);
            List<IEvento> DatoEvento = validarTiempoDeEvento.EvaluarTiempoPorHoras(eventos);

            Console.WriteLine(construirRespuestaEvento.ConstruirInfoEvento(DatoEvento));
            Console.ReadLine();

        }
    }
}
