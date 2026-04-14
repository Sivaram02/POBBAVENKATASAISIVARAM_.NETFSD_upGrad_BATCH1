using healthcareapi.Models;
using healthcareapi.Repositories.Interfaces;

namespace healthcareapi.Services
{
    public class PrescriptionService
    {
        private readonly IGenericRepository<Prescription> _repo;

        public PrescriptionService(IGenericRepository<Prescription> repo)
        {
            _repo = repo;
        }

        public async Task Add(Prescription prescription)
        {
            await _repo.Add(prescription);
        }

        public async Task<Prescription?> GetByAppointmentId(int appointmentId)
        {
            var prescriptions = await _repo.GetAll();

            return prescriptions
                .FirstOrDefault(p => p.AppointmentId == appointmentId);
        }
    }
}