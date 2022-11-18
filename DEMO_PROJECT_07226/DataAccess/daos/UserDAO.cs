﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.daos;

/// <summary>
/// Author Marc-Eric Boury
/// </summary>
[Table("Users")]
public class UserDAO : IDAO {

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
