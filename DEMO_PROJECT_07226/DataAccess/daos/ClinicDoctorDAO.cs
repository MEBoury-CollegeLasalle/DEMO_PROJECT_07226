using DEMO_PROJECT_07226.DataAccess.contexts;
using DEMO_PROJECT_07226.DataAccess.dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.daos;
public class ClinicDoctorDAO : IDAO {
    private ClinicContext context;

    public ClinicDoctorDAO(ClinicContext context) {
        this.context = context;
    }

    public List<DoctorDTO> GetDoctorsOfAClinic(int clinicId) {
        List<ClinicDoctorDTO> clinicDoctors =  this.context.ClinicDoctors
            .Where(clinicDoctor => clinicDoctor.ClinicId == clinicId)
            .Include(clinicDoctor => clinicDoctor.Doctor)
            .ToList();

        List<DoctorDTO> doctors = new List<DoctorDTO>();
        foreach (ClinicDoctorDTO clinicDoc in clinicDoctors) {
            doctors.Add(clinicDoc.Doctor);
        }

        return doctors.Distinct().ToList();

    }
}
