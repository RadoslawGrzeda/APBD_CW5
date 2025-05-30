using System.Xml;
using APBD_CW5.DAL;
using APBD_CW5.DTO;
using APBD_CW5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Prescription = APBD_CW5.Models.Prescription;
using Prescription_Medicament = APBD_CW5.Models.Prescription_Medicament;

namespace APBD_CW5.Services;

public class PrescriptionService : IPrescriptionService
{
    private readonly Hospital _context;

    public PrescriptionService(Hospital context)
    {
        _context = context;
    }


    public async Task AddPrescriptionAsync(AddPrescriptionDto dto)
    {
        if (dto.Medicaments.Count > 10)
            throw new ArgumentException("Medicaments count can't be less than 10");

        var doctor = await _context.Doctors.FindAsync(dto.IdDoctor);
        if (doctor == null)
            throw new ArgumentException("Doctor not found");

        var patient = _context.Patients.FirstOrDefault(p =>
            p.FirstName == dto.FirstName &&
            p.LastName == dto.LastName &&
            p.BirthDate == dto.BirthDate);


        if (patient == null)
        {
            patient = new Patient
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                BirthDate = dto.BirthDate,
            };
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        var medId = dto.Medicaments.Select(a => a.IdMedicament).ToList();
        var exisistingMed = await _context.Medicaments
            .Where(m => medId.Contains(m.IdMedicament))
            .Select(m => m.IdMedicament)
            .ToListAsync();

        if (exisistingMed.Count != medId.Count)
            throw new ArgumentException("Medicaments do not exist");

        var prescription = new Prescription
        {
            Date = dto.Date,
            DueDate = dto.DueDate,
            IdDoctor = doctor.IdDoctor,
            IdPatient = patient.IdPatient,
            Prescription_Medicaments = new List<Prescription_Medicament>()
        };
        foreach (var m in dto.Medicaments)
        {
            prescription.Prescription_Medicaments.Add(new Prescription_Medicament
            {
                IdMedicament = m.IdMedicament,
                Dose = m.Dose,
                Details = m.Details
            });
        }
        

        _context.Prescriptions.Add(prescription);
            await _context.SaveChangesAsync();
        }
    }
    
    