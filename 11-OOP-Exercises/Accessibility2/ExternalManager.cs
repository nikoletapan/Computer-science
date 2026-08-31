using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility2
{
    public class ExternalManager : Employee
    {
        public void Show()
        {
            Console.WriteLine(Name);        // OK - public
            //Console.WriteLine(salary);    // ERROR - private
            Console.WriteLine(age);         // OK - protected
            //Console.WriteLine(department);// ERROR - internal
            Console.WriteLine(role);        // OK - protected internal
            //Console.WriteLine(id);        // ERROR - private protected (друг проект)
        }

    }
}
