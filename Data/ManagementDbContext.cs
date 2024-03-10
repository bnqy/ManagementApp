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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			SeedData.AddEmployeeData(modelBuilder);
		}

		public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }
    }
}
