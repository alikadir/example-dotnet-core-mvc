using Microsoft.EntityFrameworkCore;

namespace FirstDotnetCoreMVC.Models
{
    public class EmployeeDbContext : DbContext
    {
        /*
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        */

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
    }
}