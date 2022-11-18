using DEMO_PROJECT_07226.DataAccess.dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.DataAccess.contexts;

/// <summary>
/// Author Marc-Eric Boury
/// </summary>
public class LoginContext : DbContext {

    public DbSet<UserDTO> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder buildOptions) {
        buildOptions.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=db_project_07226;Integrated security=true;TrustServerCertificate=true;");
    }
}
