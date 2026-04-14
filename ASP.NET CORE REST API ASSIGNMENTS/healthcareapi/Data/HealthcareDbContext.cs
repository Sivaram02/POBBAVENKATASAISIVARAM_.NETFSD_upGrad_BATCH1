using Microsoft.EntityFrameworkCore;
using healthcareapi.Models;

namespace healthcareapi.Data
{
    public class HealthcareDbContext : DbContext
    {
        public HealthcareDbContext(DbContextOptions<HealthcareDbContext> options)
            : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Prescription)
                .WithOne(p => p.Appointment)
                .HasForeignKey<Prescription>(p => p.AppointmentId);
        }
    }
}