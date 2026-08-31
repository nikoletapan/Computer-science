using System.Data;
using System.Xml.Linq;

namespace Accessibility_external
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class ManagerExternal : Employee
    {
        public void Show()
        {
            Console.WriteLine(Name);       // OK - public
                                           // Console.WriteLine(salary);  // ERROR - private
                                           // Console.WriteLine(age);     // OK - protected
                                           // Console.WriteLine(department); // ERROR - internal
            Console.WriteLine(role);       // OK - protected internal
                                           // Console.WriteLine(id);      // ERROR - private protected (друг проект)
        }

    }
}
