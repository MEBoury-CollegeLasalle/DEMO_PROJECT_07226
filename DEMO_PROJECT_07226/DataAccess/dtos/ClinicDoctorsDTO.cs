using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.dtos;

[Table("ClinicDoctors")]
public class ClinicDoctorDTO {

    [Key]
    public int Id { get; set; }

    [Required]
    public int DoctorId { get; set; }

    [Required]
    public int ClinicId { get; set; }


    [ForeignKey("DoctorId")]
    public DoctorDTO Doctor { get; set; }


    [ForeignKey("ClinicId")]
    public ClinicDTO Clinic { get; set; }
}
