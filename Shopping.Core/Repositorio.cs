using System.Collections.Generic;
using System.Linq; 

namespace Shopping.Core
{
    public static class Repositorio
    {
        static int Sucursal = 1;

        static int Id = 1; 

        static readonly List<Persona> personas = new List<Persona>();

        public static IEnumerable<Persona> Personas
            => personas; 
        
        public static Persona GetPersona(int Id)
            => personas.Find(c => c.Id == Id); 

        public static void AgregarPersona(Persona persona)
        {
            persona.Id = Id++;
            personas.Add(persona);
        }

        static readonly List<Local> locales = new List<Local>();
        
        public static IEnumerable<Local> Locales
            => locales; 
        
        public static Local GetLocal(int Sucursal)
            => locales.Find(c => c.Sucursal == Sucursal);

        public static void AgregarLocal(Local local)
        {
            local.Sucursal = Sucursal++;
            locales.Add(local); 
        }

        static readonly List<Registro> registros = new List<Registro>();


    }
}
