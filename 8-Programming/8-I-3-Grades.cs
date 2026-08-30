using System;

namespace _3_grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade: ");
            double g = double.Parse(Console.ReadLine());

            if (g < 2 || g > 6) Console.WriteLine("Invalid grade!");
            else if (g < 3) Console.WriteLine("Not Assessed!");
            else if (g >= 3 && g < 3.50) Console.WriteLine("Weak!");
            else if (g >= 3.50 && g < 4.50) Console.WriteLine("Good!");
            else if (g >= 4.50 && g < 5.50) Console.WriteLine("Very Good!");
            else if (g >= 5.50) Console.WriteLine("Excellent!");
        }
    }
}
