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
            Juego aux = new Juego(0,"");
            JsonFiler<Juego> gestor = new JsonFiler<Juego>();
            string path = $"{Environment.CurrentDirectory}\\PruebaGuardado.json";

            try
            {
                gestor.Guardar(path, juego);
                gestor.Leer(path, out aux);
            }
            catch(ErrorArchivosException)
            {

            }
            catch (Exception)
            {

            }

            bool mismoObjeto = aux.ControlVisual == juego.ControlVisual;
            bool mismaUbicacion = aux.Ubicacion == juego.Ubicacion;

            Assert.IsTrue(mismoObjeto);
            Assert.IsTrue(mismaUbicacion);

        }

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void GuardarInvalido()
        {
            Juego juego = new Juego(10, "Hola");
            JsonFiler<Juego> gestor = new JsonFiler<Juego>();
            string path = $"F:\\asdsasdaJDJS";
           
           gestor.Guardar(path, juego);
            
            
        }
    }
}
