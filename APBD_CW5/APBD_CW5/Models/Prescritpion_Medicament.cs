using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_CW5.Models;

public class Prescritpion_Medicament
{
    
    public int Dose { get; set; }
    public string Details { get; set; }
    //public int IdMedicament { get; set; }
    //public int IdPrescription { get; set; }
    
    [Key]
    [ForeignKey(nameof(Models.Prescription))] 
    public int IdPrescription { get; set; }
    //public ICollection<Prescription> Prescriptions  { get; set; }
    
    [Key]
    [ForeignKey(nameof(Medicament))]
    public int IdMedicament  { get; set; }
}