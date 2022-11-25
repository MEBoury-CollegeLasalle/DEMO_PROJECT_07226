using DEMO_PROJECT_07226.DataAccess.contexts;
using DEMO_PROJECT_07226.DataAccess.dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.daos;
public class PatientDAO : IDAO {
    private ClinicContext usageContext;

    public PatientDAO(ClinicContext usageContext) {
        if (usageContext is null) {
            usageContext = new ClinicContext();
        }
        this.usageContext = usageContext;
    }

    public PatientDTO GetById(int id) {
        return this.usageContext.Patients
            .Where(patient => patient.Id == id)
            .Include(patient => patient.Appointments)
            .Single();
    }

    public List<PatientDTO> GetAll() {
        return this.usageContext.Patients.ToList();
    }

    public void SaveNewPatient(PatientDTO newPatient) { 
        this.usageContext.Patients.Add(newPatient);
        this.usageContext.SaveChanges();
    }

    public void SaveModifications() {
        this.usageContext.SaveChanges();
    }

    public void DeletePatient(PatientDTO patient) {
        this.usageContext.Patients.Remove(patient);
        this.usageContext.SaveChanges();
    }
}
