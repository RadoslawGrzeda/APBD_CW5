using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_CW5.Models;

public class Prescription
{
    [Key]
    public int IdPrescripton { get; set; }
    
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    
    public int IdPatient { get; set; }
    public int IdDoctor { get; set; }

    [ForeignKey(nameof(IdPatient))]
    public Patient Patient { get; set; }

    [ForeignKey(nameof(IdDoctor))]
    public Doctor Doctor { get; set; }

    public ICollection<Prescritpion_Medicament> PrescritpionMedicaments { get; set; }
    //public ICollection<Patient> Patients { get; set; } 


    //[ForeignKey("IdDoctor")]    
    
    //public ICollection<Doctor> Doctors { get; set; }
}