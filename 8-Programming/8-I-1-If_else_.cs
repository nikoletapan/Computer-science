using System;
using System.Runtime.Intrinsics.Arm;

namespace _8class_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Enter a = ");
            int a = int.Parse(Console.ReadLine()); //double
            Console.WriteLine("Enter b = ");
            int b = int.Parse(Console.ReadLine()); //double

            if ((a <= 0) || (b <= 0))
            {
                Console.WriteLine("Error! The numbers must be positive.");
            }
            else
            {
                int p = 2 * (a + b);
                int s = a * b;
                Console.WriteLine("The Perimeter is " + p + " cm.");
                Console.WriteLine("The Square is " + s + " cm.");
            }
        }
    }
}
