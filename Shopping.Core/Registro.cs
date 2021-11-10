using System; 
using System.Collections.Generic;

namespace Shopping.Core
{
    public class Registro
    {
        public Local Local {get; set;}

        public DateTime FechaHora {get; set;}

        public Registro()
        {}

        public Registro(Local Local, DateTime FechaHora)
        {
            Local = this.Local; 

            FechaHora = this.FechaHora; 
        }

        public bool EsHoy(DateTime FechaHora)
        {
            var Hoy = DateTime.Today; 

            return Hoy.Year == FechaHora.Year && Hoy.Month == FechaHora.Month && Hoy.Day == FechaHora.Day; 
        }
    }
}
