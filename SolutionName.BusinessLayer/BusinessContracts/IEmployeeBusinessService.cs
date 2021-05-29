using SolutionName.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.BusinessLayer.BusinessContracts
{
    public interface IEmployeeBusinessService
    {
        IQueryable<Employee> GetAllEmployees();
    }
}
