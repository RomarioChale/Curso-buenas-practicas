using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aplicacion_de_eventos.Servicios.UTests
{
    [TestClass()]
    public class ValidadorTipoArchivoTests
    {
        [TestMethod()]
        public void ValidarTipoArchivo_TipoTxt_CadenaTxt()
        {
            //Arrange
            string extencion = "txt";
            ValidadorTipoArchivo SUT = new ValidadorTipoArchivo();

            //Act
            string respuesta = SUT.ValidarTipoArchivo(TipoArchivo.Txt);

            //Assert
            Assert.AreEqual(extencion, respuesta);           
        }

        [TestMethod()]
        public void ValidarTipoArchivo_TipoJson_CadenaJson()
        {
            //Arrange
            string extencion = "Json";
            ValidadorTipoArchivo SUT = new ValidadorTipoArchivo();

            //Act
            string respuesta = SUT.ValidarTipoArchivo(TipoArchivo.Json);

            //Assert
            Assert.AreEqual(extencion, respuesta);
        }
    }
}