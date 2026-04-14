using Microsoft.AspNetCore.Mvc;
using healthcareapi.Services;
using healthcareapi.Models;

namespace healthcareapi.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentService _service;

        public AppointmentsController(AppointmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAll());

        [HttpGet("patient/{patientId}")]
        public async Task<IActionResult> GetByPatient(int patientId)
            => Ok(await _service.GetByPatientId(patientId));

        [HttpPost]
        public async Task<IActionResult> Book(Appointment appointment)
        {
            await _service.Add(appointment);
            return Ok(appointment);
        }

        [HttpPut("cancel/{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            await _service.Cancel(id);
            return Ok("Appointment Cancelled");
        }
    }
}