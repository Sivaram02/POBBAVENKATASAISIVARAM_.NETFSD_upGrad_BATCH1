using System.ComponentModel.DataAnnotations;

namespace healthcareapi.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Specialization { get; set; }

        public int Experience { get; set; }

        public decimal ConsultationFee { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }
}