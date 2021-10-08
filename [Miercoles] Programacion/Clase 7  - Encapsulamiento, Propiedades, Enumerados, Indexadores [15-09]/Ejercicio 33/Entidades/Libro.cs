using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Libro
    {
        List<string> paginas = new List<string>();

        public string this [int i]
        {
            get
            {
                if(paginas.Count > i)
                {
                    foreach(string pagina in paginas)
                    {
                        if(pagina == paginas[i])
                        {
                            return this.paginas[i];
                        }
                    }
                }
                return "NO SE ENCOTROXD";
            }
            set
            {
                if(paginas.Count > i)
                {
                    this.paginas[i] = value;
                } else
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
