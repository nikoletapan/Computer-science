using System;

namespace _4_bigger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b) Console.WriteLine("They are equal.");
            else if (a > b) Console.WriteLine("The first number is greater.");
            else Console.WriteLine("The second number is greater.");
        }
    }
}
