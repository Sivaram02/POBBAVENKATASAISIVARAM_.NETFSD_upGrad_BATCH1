using System.ComponentModel.DataAnnotations;

namespace MVC_ASSIGNMENT_6.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}