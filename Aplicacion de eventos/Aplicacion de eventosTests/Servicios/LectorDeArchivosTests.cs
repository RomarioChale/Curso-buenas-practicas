using Aplicacion_de_eventos.Servicios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Aplicacion_de_eventos.UTests
{
    [TestClass()]
    public class LectorDeArchivosTests
    {
        [TestMethod()]
        public void LeerArchivoTest_RutaExistente_StringConDatosDelArchivo()
        {
            //Arrange
            string ruta = @"C:\Users\edwin.chale\Documents\Aplicacion de eventos\Curso-buenas-practicas\Aplicacion de eventos\Aplicacion de eventos\bin\Debug\Eventos.txt";
            LectorDeArchivos SUT = new LectorDeArchivos();
            //Act
            string[] respuesta = SUT.LeerArchivo(ruta);
            //Assert
            Assert.IsTrue(respuesta.Any());
        }
    }
}