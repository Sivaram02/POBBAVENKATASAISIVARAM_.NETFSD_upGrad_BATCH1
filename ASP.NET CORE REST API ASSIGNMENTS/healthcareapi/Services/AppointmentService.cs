using healthcareapi.Models;
using healthcareapi.Repositories.Interfaces;

namespace healthcareapi.Services
{
    public class AppointmentService
    {
        private readonly IGenericRepository<Appointment> _repo;

        public AppointmentService(IGenericRepository<Appointment> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Appointment?> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<IEnumerable<Appointment>> GetByPatientId(int patientId)
        {
            var appointments = await _repo.GetAll();

            return appointments.Where(a => a.PatientId == patientId);
        }

        public async Task Add(Appointment appointment)
        {
            appointment.Status = "Booked";
            await _repo.Add(appointment);
        }

        public async Task Cancel(int id)
        {
            var appointment = await _repo.GetById(id);

            if (appointment == null)
                throw new Exception("Appointment not found");

            appointment.Status = "Cancelled";

            await _repo.Update(appointment);
        }
    }
}