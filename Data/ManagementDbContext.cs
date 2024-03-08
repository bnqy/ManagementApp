using ManagementApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManagementApp.Data
{
	public class ManagementDbContext
		: DbContext
	{
        public ManagementDbContext(DbContextOptions<ManagementDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }
    }
}
