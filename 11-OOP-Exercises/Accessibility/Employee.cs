using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Accessibility
{
    public class Employee
    {
        public string Name;                  // достъпен навсякъде
        private int salary;                  // достъпен само в Employee
        protected int age;                   // достъпен в наследници
        internal string department;          // достъпен само в същия проект
        protected internal string role;      // достъпен в наследници или в същия проект
        private protected int id;            // достъпен в наследници в същия проект
    }
}
