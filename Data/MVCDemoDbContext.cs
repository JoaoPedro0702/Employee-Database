using EmployeeMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVC.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions option) : base(option) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
