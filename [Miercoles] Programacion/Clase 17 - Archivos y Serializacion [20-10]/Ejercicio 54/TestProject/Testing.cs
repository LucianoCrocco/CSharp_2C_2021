using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestProject
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        [ExpectedException (typeof(UnaExcepcion))]
        public void TestMiClase()
        {
            //Arrange
            MiClase miClase = new MiClase();
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestMiClase02()
        {
            //Arrange
            MiClase miClase = new MiClase(10);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMiDivideByZero()
        {
            //Act
            MiClase.MiMetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestOtraClase()
        {
            //Arrange
            OtraClase otraClase = new OtraClase();
            //Act
            otraClase.Metodo();
        }
    }
}
