using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.EmployeePayrollContext
{
    public class EmployeePayrollContext1:DbContext
    {
        public EmployeePayrollContext1(DbContextOptions options)
          : base(options)
        {
        }
        public DbSet<Employee>Employees { get; set; }

     
    }
}
