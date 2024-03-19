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

        public async Task<List<ReportToModel>> GetReportToEmployees()
        {
            try
            {
                var employees = await (from e in this._managementDbContext.Employees
                                       join j in this._managementDbContext.EmployeeJobTitles
                                       on e.EmployeeJobTitleId equals j.EmployeeJobTitleId
                                       where j.Name.ToUpper() == "TL" || j.Name.ToUpper() == "SM"
                                       select new ReportToModel
                                       {
                                           ReportToEmpId = e.Id,
                                           ReportToName = e.FirstName + " " + e.LastName.Substring(0,1).ToUpper() + ".",
                                       }).ToListAsync();

                return employees;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
