using APBD_CW5.DTO;
using APBD_CW5.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_CW5.Controllers;

[ApiController]
[Route("api/prescritpions")]
public class PrescritpionController : ControllerBase
{
    private readonly IPrescriptionService _service;

    public PrescritpionController(IPrescriptionService service)
    {
        _service = service;
    }

    public async Task<IActionResult> AddPrescription(AddPrescriptionDto dto)
    {
        try
        {
            await _service.AddPrescriptionAsync(dto);
            return Ok();
        }
        catch (ArgumentException e)
        {
            return BadRequest(e.Message);
        }
    }
}