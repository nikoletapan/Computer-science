using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository() 
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Мария", Family = "Георгиева", Phone = "0123456789", Email = "Maria@omg.bg",  Department = "Biology" },
                new Employee() { Id = 25, Name = "Николета", Family = "Панайотова", Phone = "9876543210", Email = "nikoleta@omg.bg", Department = "IT"  }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            // return _employeeList[id];
            return _employeeList.FirstOrDefault( e => e.Id == id);   
        }
    }
}
