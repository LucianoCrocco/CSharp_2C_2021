using System;

namespace Entidades
{
    public class MiClase
    {
        private int numero;
        public MiClase()
        {
            try
            {
                MiMetodoEstatico();
            } catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Una Excepcion desde Mi Clase", ex);
            }
        }

        public MiClase(int numero)
        {
            this.numero = numero;
            try
            {
                MiClase clase = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                UnaExcepcion miExpecion = new UnaExcepcion("Una excepcion en MiClase", ex);
                throw miExpecion;
            }
        }

        public static string MiMetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
