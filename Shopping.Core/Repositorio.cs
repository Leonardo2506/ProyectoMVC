using System.Collections.Generic;
using System.Linq; 

namespace Shopping.Core
{
    public static class Reposito
    {
        static int Sucursal = 1;

        static int Id = 1; 

        static readonly List<Registro> Entrada = new List<Registro>();

        static readonly List<Registro> Salida = new List<Registro>();

        public static List<Registro> Entrada => entrada; 

        public static List<Registro> Salida => salida; 

        public static void AgregarEntrada(Registro registro)
        {
            entrada.Registro = registro++;
            entrada.Add(registro); 
        }

        public static void EliminarEntrada(Persona persona)
            => persona.RemoveAll()
    }
}
