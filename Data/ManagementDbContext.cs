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
    }
}
