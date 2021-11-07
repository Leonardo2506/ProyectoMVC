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
            => personas.Find(c => c.Id == Id); 

        public static void AgregarPersona(Persona persona)
        {
            persona.Id = Id++;
            personas.Add(persona);
        }

        static readonly List<Local> locales = new List<Local>();
        
          
        static readonly List<Registro> registros = new List<Registro>();

        //static readonly List<Registro> Entrada = new List<Registro>();

        //static readonly List<Registro> Salida = new List<Registro>();

        public static List<Registro> Entrada => entrada; 

        public static List<Registro> Salida => salida; 

        //public static void AgregarEntrada(Registro registro)
        //{
           //entrada.Registro = registro++;
            //entrada.Add(registro); 
        //}

    }
}
