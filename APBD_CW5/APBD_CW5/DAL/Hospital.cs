using APBD_CW5.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_CW5.DAL;

public class Hospital:DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    protected Hospital()
    {
    }

    public Hospital(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prescription_Medicament>().HasKey(pm => new { pm.IdPrescription, pm.IdMedicament });
    }

}