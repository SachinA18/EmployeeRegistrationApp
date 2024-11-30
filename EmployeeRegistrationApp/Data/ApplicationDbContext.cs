using Microsoft.EntityFrameworkCore;
using EmployeeRegistrationApp.Models;

namespace EmployeeRegistrationApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Employee> Employees { get; set; }
    }
}
