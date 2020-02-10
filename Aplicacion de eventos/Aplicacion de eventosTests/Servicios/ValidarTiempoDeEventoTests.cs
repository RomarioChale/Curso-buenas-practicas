using Aplicacion_de_eventos.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacion_de_eventos.Servicios.UTests
{
    [TestClass()]
    public class ValidarTiempoDeEventoTests
    {
        

        [TestMethod()]
        [DataRow (.5)]
        [DataRow (10)]
        [DataRow (30)]
        [DataRow (735)]
        public void EvaluarTiempoPorHoras_ListaDeEventos_ListaConDatosNuevos(double horas)
        {
            //Arrange

            List<IEvento> eventosFecha = new List<IEvento>()
            {
                new Evento()
            };

            Mock<ICalcularDiferenciaDeFechas> mock = new Mock<ICalcularDiferenciaDeFechas>();
            mock.Setup(m => m.DirerenciaFechaActualYFechaEvento(It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(horas);

            //Act
            ValidarTiempoDeEvento SUT = new ValidarTiempoDeEvento(mock.Object);
            List<IEvento> eventos = SUT.EvaluarTiempoPorHoras(eventosFecha);

            //Assert
            Assert.IsTrue(eventos.Any());

        }
    }
}