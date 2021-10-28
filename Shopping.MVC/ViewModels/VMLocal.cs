using Shopping.Core; 
using System.Collections.Generic; 

namespace Shopping.ViewModels
{
    public class VMLocal
    {
        public Local local {get; set;}

        public IEnumerable<Persona> Personas { get; set; }

        public int? id { get; set; } 

        public VMLocal() => local = new Local();

        public VMLocal(IEnumerable<Persona> personas): this()
                => Personas  =  personas;

        public VMLocal(Local local)
        {
            Local = local; 
        }

        public static void AgregarLocal(Local local) 
        {
            
        }
    }
}