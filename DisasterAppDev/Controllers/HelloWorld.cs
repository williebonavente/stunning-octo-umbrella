using Microsoft.AspNetCore.Mvc;
using DisasterAppDev.Models;

namespace DisasterAppDev.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HelloWorldViewModel
            {
                TestModels = new List<TestModel>
                {
                    new TestModel { Id = 1, Name = "Test Item 1", Age = 25, Description = "Number 2 Description" },
                    new TestModel { Id = 2, Name = "Test Item 2", Age = 30, Description = "Number 3 Description" },
                    new TestModel { Id = 3, Name = "Test Item 3", Age = 35, Description = "Number 4 Description" },
                    new TestModel { Id = 4, Name = "Test Item 4", Age = 39, Description = "Number 5 Description" },
                },
                Message = "Welcome  to the HelloWorld page!"
            };
            return View(viewModel); // Pass the model  to the view
        }
    }
}
