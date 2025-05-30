namespace APBD_CW5.DTO;

public class GetPatientInformationDto
{
    public int IdPatient { get; set; }

    public string FirstName  { get; set; }
    
    public string  LastName { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public ICollection<PrescriptionDto> Prescriptions { get; set; }
    
}

public class PrescriptionDto
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DoctorDto DoctorDto { get; set; }
    public DateTime DueDate { get; set; }

    public ICollection<MedicamentDto> Medicaments { get; set; }
}
public class MedicamentDto
{
    public int IdMedicament { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Dose { get; set; }
}

public class DoctorDto
{
    public int IdDoctor { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
}
