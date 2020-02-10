using Aplicacion_de_eventos.Interfaces;
using Aplicacion_de_eventos.Utilerias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Aplicacion_de_eventos.Servicios.UTests
{
    [TestClass()]
    public class ConstruirRespuestaEventoTests
    {
        [TestMethod()]
        public void ConstruirInfoEvento_ListaConDatosDeEvento_CadenaConDatosDeEventos()
        {
            //Arrange
            Evento evento = new Evento()
            {
                Nombre = "Navidad",
                Estatus = Estatus.Ocurrió,
                CantidadTiempo = 3,
                UnidadTiempo = UnidadTiempo.Meses
            };
            string esperando = "El evento: Navidad Ocurrió en 3 Meses";
            List<IEvento> eventos = new List<IEvento>() { evento };

            ConstruirRespuestaEvento SUT = new ConstruirRespuestaEvento();

            //Act
            string respuesta = SUT.ConstruirInfoEvento(eventos);

            //Assert
            Assert.IsTrue(esperando.Contains(esperando));

        }
    }
}