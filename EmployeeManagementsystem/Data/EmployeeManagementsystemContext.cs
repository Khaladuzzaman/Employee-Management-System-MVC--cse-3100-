using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementsystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EmployeeManagementsystem.Data
{
    public class EmployeeManagementsystemContext : IdentityDbContext
    {
        public EmployeeManagementsystemContext (DbContextOptions<EmployeeManagementsystemContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementsystem.Models.Employee> Employee { get; set; } = default!;

        public DbSet<EmployeeManagementsystem.Models.Department>? Department { get; set; }

        public DbSet<EmployeeManagementsystem.Models.Position>? Position { get; set; }

        public DbSet<EmployeeManagementsystem.Models.Salary>? Salary { get; set; }
    }
}
