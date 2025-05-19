using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WanderWorld.Data
{
    public class EmployeeMangerContext : DbContext
    {
        public EmployeeMangerContext 
            (DbContextOptions<EmployeeMangerContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
