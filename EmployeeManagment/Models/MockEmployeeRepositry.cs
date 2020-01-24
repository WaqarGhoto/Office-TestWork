using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class MockEmployeeRepositry :IEmployeeRepositry
    {

        private List<Employee> _employeeList;

        public MockEmployeeRepositry()
        {

            Dept HR = new Dept(1, "HR");
            Dept CS = new Dept(1, "CS");
            Dept DotNet = new Dept(1, "Dot Net Core");

            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="waqar",Department=HR,Email="abc@gmail.com"},
                new Employee(){Id=2,Name="Ahmad",Department=CS,Email="abc@gmail.com"},
                new Employee(){Id=3,Name="Rubeel",Department=DotNet,Email="abc@gmail.com"},
                new Employee(){Id=4,Name="Izhar",Department=HR,Email="abc@gmail.com"},
            };
        }

        public Employee Add(Employee employee)
        {
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }


        public Employee GetEmployee(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id ==employeeChanges.Id);

            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Department = employeeChanges.Department;
                employee.Email = employeeChanges.Email;
            }
            return employee;
        }
    }
}
