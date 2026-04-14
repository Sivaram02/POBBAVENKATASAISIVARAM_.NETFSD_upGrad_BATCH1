using Microsoft.AspNetCore.Mvc;
using healthcareapi.Services;
using healthcareapi.Models;

namespace healthcareapi.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientsController : ControllerBase
    {
        private readonly PatientService _service;

        public PatientsController(PatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _service.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Create(Patient patient)
        {
            await _service.Add(patient);
            return Ok(patient);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Patient patient)
        {
            patient.PatientId = id;
            await _service.Update(patient);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}