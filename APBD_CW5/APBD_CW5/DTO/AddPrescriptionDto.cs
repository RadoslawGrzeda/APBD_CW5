namespace APBD_CW5.DTO;

public class AddPrescriptionDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; } 
    
    public int IdDoctor { get; set; }

    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    
    public List<MedicamentPrescriptionDTO> Medicaments { get; set; }
    
}

public class MedicamentPrescriptionDTO
{
    public int IdMedicament { get; set; }
    public int Dose {get; set;}
    public string Details { get; set; }
}