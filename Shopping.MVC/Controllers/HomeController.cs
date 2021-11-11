using Microsoft.AspNetCore.Mvc;

namespace Shopping.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
