using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.MVC.Models;

namespace Shopping.MVC.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View(Repositorio.Personas);
        }

        public IActionResult Detalle(int Id)
        {
            var persona = Repositorio.GetPersona(Id); 
            if(persona is null)
            {
                return NotFound(); 
            }
            return View(persona); 
        } 

        [HttpGet]
        public IActionResult DarAltaPersona() => View(); 

        [HttpPost]
        public IActionResult DarAltaPersona(Persona persona) 
        {
            Repositorio.AgregarPersona(persona);
            return View("El local esta a cargo por", persona);
        }

        
    }
}