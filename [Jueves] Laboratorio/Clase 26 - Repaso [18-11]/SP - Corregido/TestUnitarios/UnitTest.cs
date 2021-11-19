using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GuardarYLeerJson()
        {
            Juego juego = new Juego(10, "Hola");
            Juego aux;
            JsonFiler<Juego> gestor = new JsonFiler<Juego>();
            string path = $"prueba.json";

            
            gestor.Guardar(path, juego);
            gestor.Leer(path, out aux);

            Assert.AreEqual(juego.Ubicacion, aux.Ubicacion);

        }

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void GuardarInvalido()
        {
            Juego juego = new Juego(10, "Hola");
            JsonFiler<Juego> gestor = new JsonFiler<Juego>();
            string path = $"F   FSA:\\asdsasdaJDJS";
           
            gestor.Guardar(path, juego);
        }

        [TestMethod]
        public void AvanzarJuego()
        {
            Juego juego = new Juego(10, new object());
            Juego.Velocidad = 10;
            short expected = juego.Avanzar();

            Assert.AreEqual(expected, 20);
        }
    }
}
