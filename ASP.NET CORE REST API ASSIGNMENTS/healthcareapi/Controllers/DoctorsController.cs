using healthcareapi.Models;
using healthcareapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace healthcareapi.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorService _service;

        public DoctorsController(DoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _service.GetById(id));

        [HttpGet("specialization/{spec}")]
        public async Task<IActionResult> GetBySpecialization(string spec)
            => Ok(await _service.GetBySpecialization(spec));

        [HttpPost]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            await _service.Add(doctor);
            return Ok(doctor);
        }
    }
}