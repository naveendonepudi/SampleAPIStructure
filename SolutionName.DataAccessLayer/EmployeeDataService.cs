using SolutionName.DataAccessLayer.DataContracts;
using SolutionName.EntityFrameworkLayer;
using SolutionName.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.DataAccessLayer
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly IRepositoryService<Employee> _employeeRepository;
        public EmployeeDataService(IRepositoryService<Employee> repository)
        {
            _employeeRepository = repository;
        }
        public IQueryable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }
    }
}
