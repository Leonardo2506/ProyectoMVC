using System;
using System.Collections.Generic;
using System.Linq; 

namespace Shopping.Core
{
    public class Persona
    {
        public int Id {get; set;}

        public string Nombre {get; set;}

        public string Apellido {get; set;}

        public List<Local> Locales {get; set;}

        public Persona()
        {
            Locales = new List<Local>{};
        }

        public void AgregarLocal(Local local) => Locales.Add(local);   
    }
}
