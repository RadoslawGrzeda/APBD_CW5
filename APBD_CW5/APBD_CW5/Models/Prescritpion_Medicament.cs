using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_CW5.Models;

[PrimaryKey(nameof(IdPrescription),nameof(IdMedicament))]
[Table("Prescritpion_Medicament")]
public class Prescritpion_Medicament
{
    
    public int Dose { get; set; }
    public string Details { get; set; }
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    
    [ForeignKey(nameof(IdPrescription))] 
    public Prescription Prescription { get; set; }
    //public ICollection<Prescription> Prescriptions  { get; set; }
    
    [ForeignKey(nameof(IdMedicament))]
    public Medicament Medicament  { get; set; }
}