using SolutionName.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.DataAccessLayer.DataContracts
{
    public interface IEmployeeDataService
    {
        IQueryable<Employee> GetAllEmployees();
    }
}
