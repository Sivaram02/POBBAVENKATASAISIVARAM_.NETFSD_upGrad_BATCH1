using System.ComponentModel.DataAnnotations;

namespace MVC_ASSIGNMENT_6.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}