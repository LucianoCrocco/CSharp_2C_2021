using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesCentralita;
using CentralitaException;

namespace Testing
{
    [TestClass]
    public class MiTest
    {
        [TestMethod]
        public void TestValirInstanciaCentralita()
        {
            //arrange
            Centralita centralita = new Centralita();
            //act

            //assert
            Assert.AreNotEqual(null, centralita);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionesCentralita))]
        public void TestCargarMismaLlamadaLocal()
        {
            //arrange
            Centralita centralita = new Centralita();
            Llamada llamadaLocal1 = new Local("111", 90, "222", 100);
            Llamada llamadaLocal2 = new Local("111", 90, "222", 100);
            //act
            centralita += llamadaLocal1;
            centralita += llamadaLocal2;
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionesCentralita))]
        public void TestCargarMismaLlamadaProvincial()
        {
            //arrange
            Centralita centralita = new Centralita();
            Llamada llamadaProvincial1 = new Provincial("111", Provincial.Franja.Franja_1, 100, "222");
            Llamada llamadaProvincial2 = new Provincial("111", Provincial.Franja.Franja_2, 100, "222");
            //act
            centralita += llamadaProvincial1;
            centralita += llamadaProvincial2;
            //assert
        }

        [TestMethod]
        public void TestCargarDosLlamadasProvincialDosLocal()
        {
            //arrange
            Llamada llamadaLocal1 = new Local("111", 90, "222", 100);
            Llamada llamadaLocal2 = new Local("111", 90, "222", 100);
            Llamada llamadaProvincial1 = new Provincial("111", Provincial.Franja.Franja_1, 100, "222");
            Llamada llamadaProvincial2 = new Provincial("111", Provincial.Franja.Franja_2, 100, "222");
            //act

            //assert
            Assert.AreEqual(llamadaLocal1, llamadaLocal2);
            Assert.AreEqual(llamadaProvincial1, llamadaProvincial2);
            Assert.AreNotEqual(llamadaLocal1, llamadaProvincial1);
            Assert.AreNotEqual(llamadaLocal1, llamadaProvincial2);

        }
    }
}
