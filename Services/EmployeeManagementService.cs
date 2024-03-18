using ManagementApp.Data;
using ManagementApp.Entities;
using ManagementApp.Extensions;
using ManagementApp.Models;
using ManagementApp.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ManagementApp.Services
{
	public class EmployeeManagementService
		: IEmployeeManagementService
	{
		private readonly ManagementDbContext _managementDbContext;

		public EmployeeManagementService(ManagementDbContext managementDbContext)
        {
			this._managementDbContext = managementDbContext;
		}

        public async Task<List<EmployeeModel>> GetEmployees()
		{
			try
			{
				return await this._managementDbContext.Employees.Convert();  // add this
			}
			catch (Exception ex)
			{
				throw;
			}
		}

        public async Task<List<EmployeeJobTitle>> GetEmployeeJobs()
        {
            try
            {
				return await this._managementDbContext.EmployeeJobTitles.ToListAsync();  // add this
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
