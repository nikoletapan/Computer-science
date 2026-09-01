using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string Phone {get; set; }

        public string Email { get; set; }

        public string Department { get; set; }
    }
}
