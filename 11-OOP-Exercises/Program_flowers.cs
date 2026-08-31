#define START
using System.Numerics;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###### Масиви и списъци ######");
#if IGNORE
            Console.WriteLine("Въведете редица с десетични числа: ");
            double[] numbersD = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Console.WriteLine("Редица: " + string.Join('-', numbersD));

            MinMaxValue(numbersD);

            Array.Sort(numbersD);
            Array.Reverse(numbersD);

            Console.WriteLine("Редица: " + string.Join('-', numbersD));

            Array.Resize(ref numbersD, numbersD.Length + 5);
            Console.WriteLine("Редица: " + string.Join(' ', numbersD));

            numbersD[numbersD.Length - 1] = 88.88;
            Console.WriteLine("Редица: " + string.Join(' ', numbersD));
        
            
#else
            string[] animals = new string[5];

            List<string> flowers = new List<string>() { "невен", "роза", "далия", "камелия", "невен"};

            flowers.Add("маргаритки");
            flowers.Add("теменужки");

            Console.WriteLine(flowers[1]);
            Console.WriteLine("Цветя: " + string.Join(", ", flowers));
            flowers.RemoveAll(f => f == "невен");
            Console.WriteLine("Цветя: " + string.Join(", ", flowers));
            flowers.Insert(2, "лилия");
            bool snowdrop = flowers.Contains("кокиче");
            Console.WriteLine((snowdrop)?"Да":"Не");
#endif
            Console.WriteLine("###### КРАЙ! ######");
        }

        private static void MinMaxValue(double[] array)
        {
            double min = double.MaxValue; //array[0];
            double max = double.MinValue; //array[0];

            double sum = 0;

            foreach (double value in array)
            {
                if(value < min) min = value;
                if(value > max) max = value;
                sum += value;
            }
            Console.WriteLine($"Min: {min} Max: {max} Sum: {sum:F2}");
            Console.WriteLine($"Вградени min: {array.Min()} max: {array.Max()} sum: {array.Sum():F2}");
        }
    }
}
