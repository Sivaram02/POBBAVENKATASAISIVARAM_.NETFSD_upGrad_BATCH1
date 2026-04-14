using healthcareapi.Models;
using healthcareapi.Repositories.Interfaces;

namespace healthcareapi.Services
{
    public class DoctorService
    {
        private readonly IGenericRepository<Doctor> _repo;

        public DoctorService(IGenericRepository<Doctor> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Doctor?> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Add(Doctor doctor)
        {
            await _repo.Add(doctor);
        }

        public async Task<IEnumerable<Doctor>> GetBySpecialization(string specialization)
        {
            var doctors = await _repo.GetAll();

            return doctors.Where(d =>
                !string.IsNullOrEmpty(d.Specialization) &&
                d.Specialization.Equals(specialization, StringComparison.OrdinalIgnoreCase));
        }
    }
}