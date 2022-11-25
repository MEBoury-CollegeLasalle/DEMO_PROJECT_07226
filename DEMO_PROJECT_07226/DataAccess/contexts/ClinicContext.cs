using DEMO_PROJECT_07226.DataAccess.dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.contexts;

/// <summary>
/// Author: MArc-Eric Boury
/// </summary>
public class ClinicContext : DbContext {

    public DbSet<PatientDTO> Patients { get; set; }
    public DbSet<AppointmentDTO> Appointments { get; set; }
    public DbSet<DoctorDTO> Doctors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("Server=.\\SQL2019EXPRESS;Integrated security=true;Database=db_project_07226;TrustServerCertificate=true;");
    }
}
