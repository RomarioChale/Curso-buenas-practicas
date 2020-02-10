using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Aplicacion_de_eventos.Servicios.UTests
{
    [TestClass()]
    public class CalcularDiferenciaDeFechasTests
    {
        [TestMethod()]
        public void DirerenciaFechaActualYFechaEvento_FechasEventoYFechaActual_DiferenciaEnHoras()
        {
            //Arrange
            DateTime fechaEvento = new DateTime(2020,02,12,1,0,0);
            DateTime fechaActual = new DateTime(2020, 02, 12, 3, 0, 0);
            CalcularDiferenciaDeFechas SUT = new CalcularDiferenciaDeFechas();
            //Act
            double diferencia = SUT.DirerenciaFechaActualYFechaEvento(fechaEvento, fechaActual);
            //Assert
            Assert.IsTrue(Math.Abs(diferencia) == 2);
        }
    }
}