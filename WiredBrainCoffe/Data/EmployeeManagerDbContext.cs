using Microsoft.EntityFrameworkCore;
using WiredBrainCoffe.Data.Model;

namespace WiredBrainCoffe.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) :base(options)
        {
           
        }
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Department> Departments => Set<Department>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Finance" },
                new Department { Id = 2, Name = "Sales" },
                new Department { Id = 3, Name = "Marketing" },
                new Department { Id = 4, Name = "Human Resources" },
                new Department { Id = 5, Name = "IT" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Ulises", LastName = "Rodriguez", DepartmentId = 5, IsDeveloper = true },
                new Employee { Id = 2, FirstName = "Ana Maria", LastName = "Del Rio", DepartmentId = 1 },
                new Employee { Id = 3, FirstName = "Uriel", LastName = "Rodriguez", DepartmentId = 3, },
                new Employee { Id = 4, FirstName = "Gabriela", LastName = "Rodriguez", DepartmentId = 4 });
        }
    }
}
