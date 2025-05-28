using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_CW5.Models;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }

    public string FirstName  { get; set; }
    
    public string  LastName { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public ICollection<Prescription> Prescriptions { get; set; }
    //[ForeignKey("IdPrescripton")]
    //public Prescription Prescription { get; set; }
}