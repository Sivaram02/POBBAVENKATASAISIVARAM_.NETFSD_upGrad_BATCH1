using System.ComponentModel.DataAnnotations;

namespace healthcareapi.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }

        [Required]
        public string? Status { get; set; }

        public Prescription? Prescription { get; set; }
    }
}