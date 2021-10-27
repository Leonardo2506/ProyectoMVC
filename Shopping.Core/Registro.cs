using System; 

namespace Shopping.Core
{
    public class Registro
    {
        public Local local {get; set;}

        public DateTime FechaHora {get; set;}

        public Registro()
        {}

        public Registro(Local local, DateTime FechaHora)
        {
            Local = local; 

            FechaHora = fechaHora; 
        }
    }
}
