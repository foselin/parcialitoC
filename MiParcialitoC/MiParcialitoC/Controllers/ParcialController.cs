using Microsoft.AspNetCore.Mvc;

namespace MiParcialitoC.Controllers
{
    public class ParcialController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Enter()
        {
            return View();
        }
    }
}
