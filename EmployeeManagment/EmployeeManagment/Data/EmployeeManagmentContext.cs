#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagment.Models;

namespace EmployeeManagment.Data
{
    public class EmployeeManagmentContext : DbContext
    {
        public EmployeeManagmentContext (DbContextOptions<EmployeeManagmentContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagment.Models.Employee> Employee { get; set; }
    }
}
