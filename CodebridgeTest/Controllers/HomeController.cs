using CodebridgeTest.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CodebridgeTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ping()
        {
            return Ok(Consts.ApplicationVersion);
        }
    }
}
