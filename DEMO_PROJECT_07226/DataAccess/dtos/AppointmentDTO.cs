using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.dtos;

[Table("Appointments")]
public class AppointmentDTO : IDTO {

    [Key]
    public int Id { get; set; }

    [Required]
    public int PatientId { get; set; }

    [Required]
    public int DoctorId { get; set; }

    [Required]
    public int ClinicId { get; set; }

    [Required]
    public DateTime AppointmentDateAndTime { get; set; }



    [ForeignKey("PatientId")]
    public PatientDTO Patient { get; set; } = null!;

    [ForeignKey("DoctorId")]
    public DoctorDTO Doctor { get; set; } = null!;

    [ForeignKey("ClinicId")]
    public ClinicDTO Clinic { get; set; } = null!;


    public AppointmentDTO(int patientId, int doctorId, int clinicId, DateTime appointmentDateAndTime) {
        this.PatientId = patientId;
        this.DoctorId = doctorId;
        this.ClinicId = clinicId;
        this.AppointmentDateAndTime = appointmentDateAndTime;
    }


}
