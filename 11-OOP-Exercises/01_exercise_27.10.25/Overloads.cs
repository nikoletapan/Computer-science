using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    internal class Overloads
    {
        public void Area()
        {
            Console.WriteLine("Демонстрация на презареждане с имена: ");
        }
        public void Area(int a)
        {
            Console.WriteLine($"Лице на квадрат: {a*a}");
        }

        public void Area(int a, int b) 
            {
            Console.WriteLine($"Лице на правоъгълник: {a*b}");
        }
        public void Area(int a, int b, int c)
        {
            double p = (double)(a + b + c)/2;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c)); // square root
            Console.WriteLine($"Лице на триъгълник: {s}");
        }
        public void Area(double r)
        {
            Console.WriteLine($"Лице на кръг: {2*Math.PI*r:F2}");
        }
        public void Area(string message)
        {
            Console.WriteLine("Добре изпълнени задачи с лица!");
            Console.WriteLine("Вашият поздрав е: " + message);
        }
    }
}
