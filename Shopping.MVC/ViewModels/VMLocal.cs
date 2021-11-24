using Shopping.Core; 
using System.Collections.Generic;

namespace Shopping.ViewModels
{
    public class VMLocal 
    {
        public IEnumerable<Persona> Personas {get; set;}

        public Local Local {get; set;}

        public int? IdPersonaSeleccionada {get; set;}

        public VMLocal() => Local = new Local(); 

        public VMLocal(IEnumerable<Persona> personas) : this()
            => Personas = personas;
        
        public VMLocal(Local local, IEnumerable<Persona> Personas)
        {
            Local = local; 
        }
    }
}