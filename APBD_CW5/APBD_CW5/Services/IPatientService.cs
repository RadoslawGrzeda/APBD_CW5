using APBD_CW5.DTO;

namespace APBD_CW5.Services;

public interface IPatientService
{
    Task<GetPatientInformationDto?> GetPatientByIdAsync(int idPatient);

}