using Microsoft.AspNetCore.Mvc;

namespace DisasterAppDev.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World");
        }
    }
}
