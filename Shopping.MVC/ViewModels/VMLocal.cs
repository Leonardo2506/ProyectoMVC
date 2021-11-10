using Shopping.Core; 
using System.Collections.Generic; 

namespace Shopping.ViewModels
{
    public class VMLocal
    {
        public Local Local {get; set;}

        public IEnumerable<Persona> Personas { get; set; }

        public int? id { get; set; } 

        public VMLocal() => Local = new Local();

        public VMLocal(IEnumerable<Persona> personas): this()
                => Personas  =  personas;

        public VMLocal(Local Local)
        {
            Local = this.Local; 
        }

        public static void AgregarLocal(Local local) 
        {
            
        }
    }
}