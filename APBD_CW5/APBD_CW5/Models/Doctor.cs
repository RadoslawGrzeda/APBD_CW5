using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_CW5.Models;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    
    public ICollection<Prescription> Prescriptions { get; set; }
}