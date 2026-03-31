using System.ComponentModel.DataAnnotations;

namespace MVC_ASSIGNMENT_8.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }
    }
}