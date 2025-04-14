using Microsoft.AspNetCore.Mvc;
using DisasterAppDev.Models;

namespace DisasterAppDev.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            var model = new List<TestModel>
           {
               new TestModel { Id = 1, Name = "Test Item 1", Age  = 25, Description = "Description 1" },
               new TestModel { Id = 2, Name = "Test Item 2", Age = 30, Description = "Description 2" },
               new TestModel { Id = 3, Name = "Test Item 3", Age = 39, Description = "Description 3" }
           };

            return View(model); // Pass the model  to the view
        }
    }
}
