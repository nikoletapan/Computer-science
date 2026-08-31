#define COUNTRY  // Дефиниране в началото на файла
#define AREA

namespace _01_exercise_27._10._25
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            #region
           // Recursions.Crash();
#if COUNTRY
            Separator();
            Console.WriteLine("=== 1 зад === защита с private");
            Console.Write("Въведете име на държава: (България) ");
            Country country1 = new Country();
            country1.Frequency();
#endif
#if AREA
            Separator();
            Console.WriteLine("=== 2 зад === Презаписвания на методи");
            Overloads overloads1 = new Overloads(); // Мethods Overloads
            overloads1.Area();
            overloads1.Area(2);
            overloads1.Area(2, 3);
            overloads1.Area(2, 3, 4);
            overloads1.Area(2.7);
            overloads1.Area("Лице и площ са синоними.");
#endif
            #endregion

            Separator();
            Console.WriteLine("=== 3 зад === Рекурсии");
            Recursions recursion1 = new Recursions(); // new object
            Console.WriteLine($@"
Factorial of 6 = {recursion1.Factorial(6)} 
Power of 2 ^ 3 = {recursion1.Power(2, 3)};");
            //Recursions.Crash(); ако махнем static, ще бъде част от обекта
            //recursion1.Crash();

            Separator();
            Console.WriteLine("=== 4 зад === Обръщания на текст");
            Reverse.Chars();  // static, without new object
            Reverse.Text();
            Reverse.Words();

            Console.WriteLine("=== 5 зад === Обръщания на числа");
            Reverse.NumberArrays1();
            Reverse.NumberArrays2();
            Reverse.NumberArrays3();

            Console.WriteLine("=== 6 зад === Намиране на min или max");
            Sort sort1 = new Sort();
            Console.WriteLine("Въвеждайте числа, за да се намери най-малкото измежду тях. Спрете със stop:");
            Console.WriteLine(sort1.FindMin());
            Console.WriteLine("Аналогично се намира най-голямото число, а с допълнителен цикъл се прави сортиране");
        
            Person person = new Person();
            person.FirstName = "Misho";
            person.LastName = " ";
            Console.WriteLine(person.LastName);

            Car car1 = new Car("Mustang", "black", 1989);
            Car car2 = new Car("Shkoda", "grey", 2010);

            Console.WriteLine(car1.Model);

            Car car1 = new Car("Shkoda", "blue", 1990);
            car1.PrintInfo();*/


            Account account1 = new Account("N12345", 230);
            account1.PrintInfo();

            Account account2 = new Account(" ", 24);
            account2.PrintInfo();

            Account account3 = new Account("1234", 34);
            account3.PrintInfo();

            Account account4 = new Account("w12356", -4);
            account4.PrintInfo();
        }

        static void Separator()
        {
            Console.WriteLine(new string('-', 33));
        }
    }
}
