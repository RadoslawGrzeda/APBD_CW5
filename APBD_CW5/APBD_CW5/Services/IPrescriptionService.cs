using APBD_CW5.DTO;
using APBD_CW5.Models;

namespace APBD_CW5.Services;

public interface IPrescriptionService
{
    Task AddPrescriptionAsync(AddPrescriptionDto dto);

}