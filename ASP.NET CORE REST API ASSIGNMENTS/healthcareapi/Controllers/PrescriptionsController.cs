using healthcareapi.Models;
using healthcareapi.Services;
using healthcareapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace healthcareapi.Controllers
{
    [ApiController]
    [Route("api/prescriptions")]
    public class PrescriptionsController : ControllerBase
    {
        private readonly PrescriptionService _service;

        public PrescriptionsController(PrescriptionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Prescription prescription)
        {
            await _service.Add(prescription);
            return Ok(prescription);
        }

        [HttpGet("appointment/{appointmentId}")]
        public async Task<IActionResult> GetByAppointment(int appointmentId)
        {
            var result = await _service.GetByAppointmentId(appointmentId);
            return Ok(result);
        }
    }
}