using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public interface IEmployeeRepositry
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();

        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int id);
    }
}
