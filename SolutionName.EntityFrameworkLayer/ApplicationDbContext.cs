using Microsoft.EntityFrameworkCore;
using SolutionName.Models;
using SolutionName.Models.Department;
using System.Collections.Generic;

namespace SolutionName.EntityFrameworkLayer
{
    public partial class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
