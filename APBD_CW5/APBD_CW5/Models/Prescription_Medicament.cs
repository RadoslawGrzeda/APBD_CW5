using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_CW5.Models;

[Table("Prescription_Medicament")]
[PrimaryKey(nameof(IdPrescription), nameof(IdMedicament))]
public class Prescription_Medicament
{
    
    public int Dose { get; set; }
    public string Details { get; set; }
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    
    [ForeignKey(nameof(IdPrescription))]
    public Prescription Prescription { get; set; }

    [ForeignKey(nameof(IdMedicament))]
    public Medicament Medicament { get; set; }
}