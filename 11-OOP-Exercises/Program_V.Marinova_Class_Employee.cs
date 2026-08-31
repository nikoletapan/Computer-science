namespace V.Marinova_Class_Employee
{

    internal class Employee
    {
        private string name;
        private int age;
        private string department = "Човешки ресурси";

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Грешка: Не сте въвели име!");

                name = value;
            }
        }

        public int Age
        {
            get => age; 
            set { if (value < 18 || value > 65)
                    throw new ArgumentException("Грешка: Не сте в трудоспособна възраст!");
                
                age = value; }
        }
        public Employee(string nameF, int ageF) 
        {
            Name = nameF;
            Age = ageF;
        }

        public void PrintInfo()
        {
            Console.WriteLine($@"{new string('#', 37)}
Име: {Name}
Възраст: {Age}
Отдел: {this.department}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Иван", 50);
            employee1.PrintInfo();

            Employee employee2 = new Employee("Мария", 27);
            employee2.PrintInfo();
        }
    }
}
