using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.dtos;

[Table("Doctors")]
public class DoctorDTO : IDTO {

    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }



    public List<AppointmentDTO> Appointments { get; set; } = null!;


    public DoctorDTO(string firstName, string lastName) { 
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}
