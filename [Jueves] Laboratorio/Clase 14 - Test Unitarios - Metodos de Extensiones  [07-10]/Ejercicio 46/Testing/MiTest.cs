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
        public void TestVehiculoAgregadoEnCompetenciaIncorrecta()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(22, "Ferrari");
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
