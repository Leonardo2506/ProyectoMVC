using System.Collections.Generic;
using System.Linq; 

namespace Shopping.Core
{
    public static class Reposito
    {
        static int Sucursal = 1;

        static int Id = 1; 

        static readonly List<Persona> personas = new List<Persona>();

        public static IEnumerable<Persona> Personas 
            => personas;

        public static Persona GetPersona(int Id)
            => personas.Find(p => p.id == Id);

        public static void AgregarPersona(Persona persona)
        {
            persona.id = Id++;
            persona.Add(persona); 
        }

        public static void EliminarPersona(Persona persona)
        {
            
        }
    }
}
