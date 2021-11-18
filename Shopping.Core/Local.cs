using System;
using System.Collections.Generic;
using System.Linq; 

namespace Shopping.Core
{
    public class Local
    {
        public int Sucursal {get; set;}

        public string Nombre {get; set;}

        public string Direccion {get; set;}

        public int CantMax {get; set;}

        public List<Persona> personas{get; set;}

        public DateTime FechaHora {get; set;}

        public List<Registro> Entrada {get; set;}

        public List<Registro> Salida {get; set;}

        public Local()
        {
            Entrada = new List<Registro>{};

            Salida = new List<Registro>{}; 
        }

        public int EntradasDelDia
            => Entrada.Count(e => e.EsHoy(FechaHora));

        public int SalidasDelDia 
            => Salida.Count(e => e.EsHoy(FechaHora));

        public int Disponibilidad
            => CantMax - (SalidasDelDia - EntradasDelDia);

        public bool PuedeIngreso()
        {
            if(Disponibilidad >= 1)
            {
                return true; 
            }
            return false; 
        }

        public void AltaIngreso()
        {
            if(PuedeIngreso() == true)
            {
                Entrada.Add(new Registro(this, DateTime.Now));
            }
        }

        public void AltaEgreso(Registro registro)
        {
            Entrada.Remove(registro); 

            Salida.Add(registro); 
        }

        public int CantidadClientes()
        {
            return EntradasDelDia - SalidasDelDia;
        }
    }
}
