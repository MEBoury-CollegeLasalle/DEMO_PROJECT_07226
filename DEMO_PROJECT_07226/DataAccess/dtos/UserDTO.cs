using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.dtos;

[Table("Users")]
public class UserDTO : IDTO {

    [Column("Id")]
    [Key]
    public int Id { get; set; }

    [Column("Username")]
    [Required]
    [StringLength(32)]
    public string Username { get; set; }

    [Column("PasswordHash")]
    [Required]
    [StringLength(128)]
    public string PasswordHash { get; set; }
}
