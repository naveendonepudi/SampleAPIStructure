using SolutionName.BusinessLayer.BusinessContracts;
using SolutionName.DataAccessLayer.DataContracts;
using SolutionName.Models;
using System.Linq;

namespace SolutionName.BusinessLayer
{
    public class EmployeeBusinessService : IEmployeeBusinessService
    {
        private readonly IEmployeeDataService _employeeData;
        public EmployeeBusinessService(IEmployeeDataService employeeData)
        {
            _employeeData = employeeData; 
        }
        public IQueryable<Employee> GetAllEmployees()
        {
            return _employeeData.GetAllEmployees();
        }
    }
}
