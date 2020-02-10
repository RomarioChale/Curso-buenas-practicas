using Aplicacion_de_eventos.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacion_de_eventos.Servicios.UTests
{
    [TestClass()]
    public class AsignadorDeEventosTests
    {
        [TestMethod()]
        public void AsignarDatosDeArchivosTest_ArregloDeStringValido_ListaDeEventos()
        {
            //Arrange
            string[] datos = {
                                "Navidad , 12/02/2020",
                                "Día de la madre , 10/05/2020"
                             };
            AsignadorDeEventos SUT = new AsignadorDeEventos();

            //Act
            List<IEvento> respuesta = SUT.AsignarDatosDeArchivos(datos);

            //Assert
            Assert.IsTrue(respuesta.Any());

        }

        [TestMethod()]
        public void AsignarDatosDeArchivosTest_ArregloDeStringInValido_Excepcion()
        {
            //Arrange
            string[] datos = {
                                 ""
                             };
            AsignadorDeEventos SUT = new AsignadorDeEventos();

            //Act
            Exception respuesta = Assert.ThrowsException< Exception >(() => SUT.AsignarDatosDeArchivos(datos));

            //Assert
            Assert.AreEqual("Índice fuera de los límites de la matriz.", respuesta.Message);

        }
    }
}