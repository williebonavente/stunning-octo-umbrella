namespace DisasterAppDev.Models
{
    public class HelloWorldViewModel
    {
        public List<TestModel> TestModels { get; set; } = new List<TestModel>();
        public string Message { get; set; } = string.Empty;
    }
}
