using ManagementApp.Entities;
using ManagementApp.Models;

namespace ManagementApp.Services.Contracts
{
	public interface IEmployeeManagementService
	{
		Task<List<EmployeeModel>> GetEmployees();
		Task<List<EmployeeJobTitle>> GetEmployeeJobs();
	}
}
