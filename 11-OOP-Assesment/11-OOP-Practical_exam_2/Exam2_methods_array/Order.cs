using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_methods_array
{
    internal class Order
    {
       public static decimal Choice()
        {
            string input;        // private fields
            decimal sum = 0.0m;

            do
            {
                input = Console.ReadLine().ToLower();
                char order = char.Parse(input);

                sum = order switch
                {
                    'a' => sum += 0.80m,
                    'b' => sum += 1.70m,
                    'c' => sum += 1.20m,
                    'd' => sum += 1.50m,
                    _ => sum += 0m,
                };
            } while (input != "bill"); // string.Equals(input, "bill", StringComparison.OrdinalIgnoreCase)
            Total(sum);
            Converter(sum);
            return sum;
        } 
        private static void Total(decimal totalSum)
        {
            Console.WriteLine($"Total: {totalSum} BGN");
        }
        private static void Converter(decimal value)
        {
            Console.WriteLine("1 EUR = 1.95583 BGN");
            decimal euro = value / 1.95583m;
            Console.WriteLine($"Converted currency: {euro}");
            Console.WriteLine($"Pay: {Math.Round(euro,2)} EUR");
        }
    }
}
