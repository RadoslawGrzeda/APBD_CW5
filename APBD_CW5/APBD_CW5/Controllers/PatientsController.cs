using APBD_CW5.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_CW5.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _patientService;

    public PatientsController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpGet("{idPatient}")]
    public async Task<IActionResult> GetPatient(int idPatient)
    {
        var patient = await _patientService.GetPatientByIdAsync(idPatient);
        if (patient == null)
            return NotFound($"Pacjent o ID {idPatient} nie istnieje.");

        return Ok(patient);
    }
}