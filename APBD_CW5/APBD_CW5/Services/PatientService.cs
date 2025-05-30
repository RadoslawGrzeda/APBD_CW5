using APBD_CW5.DAL;
using APBD_CW5.DTO;
using APBD_CW5.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_CW5.Services;

public class PatientService:IPatientService
{
    private readonly Hospital _Client;

    public PatientService(Hospital Client)
    {
        _Client = Client;
    }
    
    public async Task<GetPatientInformationDto?> GetPatientByIdAsync(int idPatient)
    {
        var patient=await _Client.Patients
            .Include(p=>p.Prescriptions)
            .ThenInclude(p=>p.Doctor)
            .Include(p=>p.Prescriptions)
            .ThenInclude(p=>p.Prescription_Medicaments)
            .ThenInclude(p=>p.Medicament)
            .FirstOrDefaultAsync(p=>p.IdPatient==idPatient);

        if (patient == null)
            return null;
            
            
        return new GetPatientInformationDto
        {
            IdPatient = patient.IdPatient,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            BirthDate = patient.BirthDate,
            Prescriptions = patient.Prescriptions
                .OrderBy(p => p.DueDate)
                .Select(p => new PrescriptionDto
                {
                    IdPrescription = p.IdPrescripton,
                    Date = p.Date,
                    DueDate = p.DueDate,
                    DoctorDto = new DoctorDto
                    {
                        IdDoctor = p.Doctor.IdDoctor,
                        Firstname = p.Doctor.Firstname,
                        Lastname = p.Doctor.Lastname,
                        Email = p.Doctor.Email
                    },
                    Medicaments = p.Prescription_Medicaments.Select(pm => new MedicamentDto
                    {
                        IdMedicament = pm.Medicament.IdMedicament,
                        Name = pm.Medicament.Name,
                        Description = pm.Medicament.Description,
                        Dose = pm.Dose
                    }).ToList()
                }).ToList()
        };
    }
}