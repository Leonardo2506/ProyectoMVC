using System.Collections.Generic;
using System.Linq; 

namespace Shopping.Core
{
    public static class Reposito
    {
        static int Sucursal = 1;

        static int Id = 1; 

        public static void AgregarPersona(Persona persona)
        {
            persona.id = Id++;
            persona.Add(persona); 
        }

        public static void EliminarPersona(Persona persona)
            => persona.RemoveAll()
    }
}
