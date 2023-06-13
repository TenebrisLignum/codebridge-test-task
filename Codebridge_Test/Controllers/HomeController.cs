using Microsoft.AspNetCore.Mvc;

namespace Codebridge_Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ping()
        {
            return Ok("Dogs house service. Version 1.0.1");
        }
    }
}
