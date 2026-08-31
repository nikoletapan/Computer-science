using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    internal class Sort
    {
        private int min = int.MaxValue; // private field
        private int max = int.MinValue;
        public int FindMin()
        {
            {
                Console.WriteLine("Въведете числа:");

                while (true)
                {
                    string input = Console.ReadLine().ToLower();

                    if (input == "stop")
                    {
                        break;
                    }

                    if (int.TryParse(input, out int n))
                    {
                        if (n < min)
                        {
                            min = n;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Невалидно число! Опитайте отново.");
                    }
                }
                Console.WriteLine("min = " + min);
                return min;
            }
        }
    }
}
