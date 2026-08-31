

namespace Class_Lists_Employee
{
    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = EnterEmployees();

            HighestPaid(employees);
        }

        private static void HighestPaid(List<Employee> employees)
        {
            Console.WriteLine("\n--- СЛУЖИТЕЛ С НАЙ-ВИСОКА ЗАПЛАТА ---");
            if (employees.Count > 0)
            {
                
                Employee maxPaid = employees.MaxBy(e => e.Salary);               
                Console.WriteLine($"Служител с максимална заплата: "); 
                maxPaid.DisplayInfo();

                Employee highestPaid = employees.DefaultIfEmpty().OrderByDescending(e => e.Salary).First(); //подобна логика в MySQL 
                Console.WriteLine($"Служител с най-висока заплата: {highestPaid}"); //Ще работи само за ToString()
            }
            else
            {
                Console.WriteLine("Няма служители.");
            }
        }

        private static List<Employee> EnterEmployees()
        {
                List<Employee> employees = new List<Employee>();

                Console.WriteLine("Въведете информация за служителите (за край въведете 'край' за име):");

                while (true)
                {
                    Console.Write("Име: ");
                    string name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Името не може да бъде празно! Опитайте отново.");
                        continue;
                    }

                    if (name.ToLower() == "край")
                        break;

                    string position;
                    do
                    {
                        Console.Write("Длъжност: ");
                        position = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(position))
                            Console.WriteLine("Длъжността не може да бъде празна! Опитайте отново.");
                    } while (string.IsNullOrWhiteSpace(position));

                    Console.Write("Заплата: ");
                    decimal salary;
                    while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
                    {
                        Console.Write("Въведете валидна заплата: ");
                    }

                    employees.Add(new Employee(name, position, salary));

                    Console.WriteLine("Служителят е добавен успешно!\n");
                }

                return employees;
            }
        }
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public override string ToString() //стандартен, много инфо при дебъг
        {
            return $"Име: {Name}, Длъжност: {Position}, Заплата: {Salary:F2}";
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Име: {Name}, Длъжност: {Position}, Заплата: {Salary:F2}");
        }
    }
}
