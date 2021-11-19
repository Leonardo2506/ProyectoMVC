using Microsoft.AspNetCore.Mvc; 
using Shopping.Core; 
using System;

namespace Shopping.MVC.Controllers
{
    public class LocalController : Controller
    {
        public IActionResult Index()
        {
            return View(Repositorio.Locales); 
        }

        public IActionResult Detalle(int sucursal)
        {
            var local = Repositorio.GetLocal(sucursal);
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
        public IActionResult DarAltaLocal([Bind(Prefix = "Item1")]Local local)
        {
            Repositorio.AgregarLocal(local); 
            return View("Index", Repositorio.Locales); 
        }
    }
}