using Microsoft.AspNetCore.Mvc; 
using Shopping.Core; 

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
        public IActionResult DarAltaLocal() => View(); 

        [HttpPost]
        public IActionResult DarAltaLocal(Local local)
        {
            Repositorio.AgregarLocal(local); 
            return View("El local que fue asignado es: ", Repositorio.Locales); 
        }
    }
}