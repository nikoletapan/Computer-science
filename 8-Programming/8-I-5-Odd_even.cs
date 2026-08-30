using System;

namespace _5_odd_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0) Console.WriteLine("Invalid number!");
            else if (n % 2 == 0) Console.WriteLine("Even.");
            else Console.WriteLine("Odd.");
        }



    }
}
