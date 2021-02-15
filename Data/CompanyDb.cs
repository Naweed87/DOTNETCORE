using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Data
{
    public sealed class CompanyDb : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
