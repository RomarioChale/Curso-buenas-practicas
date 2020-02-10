using Aplicacion_de_eventos;
using Aplicacion_de_eventos.Servicios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Aplicacion_de_eventosTests
{
    /// <summary>
    /// Descripción resumida de LectorDeArchivosTest
    /// </summary>
    [TestClass]
    public class BuscadorDeArchivosTest
    {

        [TestMethod]
        [DataRow ("", "txt")]
        [DataRow ("Eventos", "txt")]
        [DataRow ("prueba", "Json")]
        public void BuscarArchivo_ArchivoExistente_CadenaConDatosDelaRutaDelArchivo(string archivo, string tipo)
        {
            //Arrange
            Mock<IValidadorTipoArchivo> mock = new Mock<IValidadorTipoArchivo>();
            mock.Setup(m => m.ValidarTipoArchivo(It.IsAny<TipoArchivo>())).Returns(tipo);

            BuscadorDeArchivos SUT = new BuscadorDeArchivos(mock.Object);
            //Act
            string expected = SUT.BuscarArchivo(archivo, TipoArchivo.Txt);
            //Assert
            Assert.IsNotNull(expected);

        }

    }
}
