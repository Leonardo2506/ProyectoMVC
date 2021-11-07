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
            return View();
        }

        [HttpGet]
        public IActionResult PersonaACargo() => View();

        [HttpPost]
        public IActionResult PersonaACargo(Persona persona) 
        {
            Repositorio.AgregarPersona(persona);
            return View("El local esta a cargo por", persona);
        }
    }
}