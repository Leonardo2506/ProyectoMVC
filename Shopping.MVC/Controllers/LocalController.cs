using Microsoft.AspNetCore.Mvc; 
using Shopping.Core; 
using System;
using System.Collections.Generic;

namespace Shopping.MVC.Controllers
{
    public class LocalController : Controller
    {
        public IActionResult Index()
        {
            return View(Repositorio.Locales); 
        }

        public IActionResult Detalle(int Sucursal)
        {
            var local = Repositorio.GetLocal(Sucursal);
            if(local is null)
            {
                return NotFound(); 
            }
            return View(local); 
        }

        [HttpGet]
        public IActionResult DarAltaLocal()
        {
            var tupla = Tuple.Create(new Local(), Repositorio.Personas);
            return View(tupla);
        }

        [HttpPost]
        public IActionResult DarAltaLocal(Tuple<Local, IEnumerable<Persona>> tuple)
        {
            Repositorio.AgregarLocal(tuple.Item1); 
            return View("Index", Repositorio.Locales); 
        }
    }
}