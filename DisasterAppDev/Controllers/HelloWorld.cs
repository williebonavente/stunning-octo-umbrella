using Microsoft.AspNetCore.Mvc;
using DisasterAppDev.Models;

namespace DisasterAppDev.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            var model = new TestModel
            {
                Id = 1,
                Name = "Test Item",
                Description = "This is a test description."
            };
            return View(model); // Pass the model  to the view
        }
    }
}
