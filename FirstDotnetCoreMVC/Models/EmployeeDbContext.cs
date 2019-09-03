using Microsoft.EntityFrameworkCore;

namespace FirstDotnetCoreMVC.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Employee> Employees { get; set; }
    }
}