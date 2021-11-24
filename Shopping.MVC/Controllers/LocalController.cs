using System;
using Microsoft.AspNetCore.Mvc; 
using Shopping.Core; 
using Shopping.ViewModels; 

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
        public IActionResult DarAltaLocal(int Id)
        {
            var vmLocal = new VMLocal(Repositorio.Personas);
            {
                vmLocal.IdPersonaSeleccionada = Id;
            }
            return View(vmLocal);
        }

        [HttpPost]
        public IActionResult DarAltaLocal(VMLocal vMLocal)
        {
            var persona = Repositorio.GetPersona(vMLocal.IdPersonaSeleccionada.Value);
            vMLocal.Local.Persona = persona;
            Repositorio.AgregarLocal(vMLocal.Local);
            return View("Index", Repositorio.Locales); 
        }
    }
}