using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace Testing
{
    [TestClass]
    public class MiTest
    {
        [TestMethod]
        public void TestInstanciaCompetencia()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 10, Competencia.TipoCompetencia.F1);
            //Act

            //Assert
            Assert.AreNotEqual(null, competencia.Competidores);
        }

        [TestMethod]
        [ExpectedException (typeof(CompetenciaNoDisponibleException))]
        //[DataRow ("Ferrari")]
        [DataRow(22, "Ferrari")]//De arriba hacia abajo ejecuta los DataRow
        [DataRow(20, "Mercedes")]
        [DataRow(18, "Alpha Tauri")]
        [DataRow(16, "Red Bull")]
        public void TestVehiculoAgregadoEnCompetenciaIncorrecta(int valueInt, string valueStr)
        {
            //Arrange
            Competencia competencia = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            //AutoF1 autoF1 = new AutoF1(22, "Ferrari");
            AutoF1 autoF1 = new AutoF1((short)valueInt, valueStr);
            //Act
            bool retorno = competencia + autoF1;
            //Assert
        }

        [TestMethod]
        public void TestVehiculoAgregadoEnCompetenciaCorrecta()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(22, "LN");
            //Act
            bool aux = competencia + motoCross;
            //Assert
            Assert.IsTrue(aux);
        }

        [TestMethod]
        public void TestVehiculoAgregadoEnCompetenciaYBuscado()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(22, "LN");
            //Act
            bool aux = competencia + motoCross;
            //Assert
            Assert.IsTrue(aux);
            Assert.IsTrue(competencia == motoCross);
        }

        [TestMethod]
        public void TestVehiculoQuitadoEnCompetenciaYBuscado()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(22, "LN");
            //Act
            bool aux = competencia + motoCross;
            aux = competencia - motoCross;
            //Assert
            Assert.IsTrue(aux);
            Assert.IsFalse(competencia == motoCross);
        }
    }
}
