using healthcareapi.Models;
using healthcareapi.Repositories.Interfaces;

namespace healthcareapi.Services
{
    public class PatientService
    {
        private readonly IGenericRepository<Patient> _repo;

        public PatientService(IGenericRepository<Patient> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Patient>> GetAll()
            => await _repo.GetAll();

        public async Task<Patient?> GetById(int id)
            => await _repo.GetById(id);

        public async Task Add(Patient p)
            => await _repo.Add(p);

        public async Task Update(Patient p)
            => await _repo.Update(p);

        public async Task Delete(int id)
            => await _repo.Delete(id);
    }
}