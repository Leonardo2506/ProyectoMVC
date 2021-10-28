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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult IngresoAlta() => View();

        [HttpPost]
        public IActionResult IngresoAlta()
        {
            Local.AltaIngreso();
            
            return View("Bienvenido, ingreso aceptado");
        } 

        [HttpGet]
        public IActionResult AltaLocal() => View();

        [HttpPost]
        public IActionResult AltaLocal()
        {
            VMLocal.()
            return View("El local fue dado de alta", );
        }
    }
}
