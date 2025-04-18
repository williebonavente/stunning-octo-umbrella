using System.ComponentModel.DataAnnotations;

namespace DisasterAppDev.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; } = string.Empty;
        [Range(18,  100, ErrorMessage = "Age must be between 18 and 100." )]
        public int Age { get; set; }
        [Required(ErrorMessage = "Description in required.")]
        public string Description { get; set; } = string.Empty;


    }
}
