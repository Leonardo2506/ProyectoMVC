using System;
using System.Linq; 

namespace Shopping.Core
{
    public class Local
    {
        public int idSucursal {get; set;}

        public string Nombre {get; set;}

        public int Direccion {get; set;}

        public int CantMax {get; set;}

        List<Registro> Entrada {get; set;}

        List<Registro> Salida {get; set;}

        public Local()
        {}

        public Local ()
        {
            Entrada = new List<Registro>{};

            Salida = new List<Registro>{}; 
        }

        private bool EsHoy(DateTime FechaHora)
        {
            var Hoy = DateTime.Today; 

            return Hoy.Year == fecha.Year && Hoy.Month == fecha.Month && Hoy.Day == fecha.Day; 
        }

        public int Disponibilidad
            => CantMax - (EntradasDelDia - SalidasDelDia);

        public bool PuedeIngreso()
        {
            if(Disponibilidad => 1)
            {
                return true; 
            }
            return false; 
        }

        public void AltaIngreso()
        {
            if(PuedeIngreso() == true)
            {
                Entrada.Add(new Registro(DateTime.now))
            }
        }

        public void AltaEgreso()
        {
            Entrada.RemoveAt(DateTime.now); 

            Salida.RemoveAt(DateTime.now); 
        }

        public int EntradasDelDia
            => Entrada.Count(EsHoy(e => e.EsHoy(e)));

        public int SalidasDelDia 
            => Salida.Count(EsHoy(e => e.EsHoy(e)));

        public int CantidadClientes()
        {
            return EntradasDelDia - SalidasDelDia;
        }
    }
}
