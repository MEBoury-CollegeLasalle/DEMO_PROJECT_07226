using DEMO_PROJECT_07226.DataAccess.contexts;
using DEMO_PROJECT_07226.DataAccess.dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.daos;
public class DoctorDAO : IDAO {
    private ClinicContext usageContext;

    public DoctorDAO(ClinicContext usageContext) {
        if (usageContext is null) {
            usageContext = new ClinicContext();
        }
        this.usageContext = usageContext;
    }

    public DoctorDTO GetById(int id) {
        return this.usageContext.Doctors
            .Where(doctor => doctor.Id == id)
            .Include(doctor => doctor.Appointments)
            .Single();
    }

    public List<DoctorDTO> GetAll() {
        return this.usageContext.Doctors.ToList();
    }

    public void SaveNewDoctor(DoctorDTO newDoctor) {
        this.usageContext.Doctors.Add(newDoctor);
        this.usageContext.SaveChanges();
    }

    public void SaveModifications() {
        this.usageContext.SaveChanges();
    }

    public void DeleteDoctor(DoctorDTO doctor) {
        this.usageContext.Doctors.Remove(doctor);
        this.usageContext.SaveChanges();
    }
}
