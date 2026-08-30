using System;

namespace _2_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                double p = 2 * Math.PI * r;
                double s = Math.PI * r * r;
                Console.WriteLine("The Perimeter is: " + p + " cm.");
                Console.WriteLine("The Square is: " + s + " cm^2");
            }
        }
    }
}
