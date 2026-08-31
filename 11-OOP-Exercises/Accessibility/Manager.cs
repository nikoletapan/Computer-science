using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility1   // в същия проект, различен namespace 
{
    public class Manager : Employee
    {
        public void Show()
        {
            Console.WriteLine(Name);       // OK
            //Console.WriteLine(salary);  // ERROR - private
            Console.WriteLine(age);        // OK - protected
            Console.WriteLine(department); // OK - internal
            Console.WriteLine(role);       // OK - protected internal
            Console.WriteLine(id);         // OK - private protected (същия проект)
        }
    }
}
