#define START


namespace Lists_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###### МАСИВИ И СПИСЪЦИ ######");
#if IGNORE
            int[] numbers = { 31, 62, 73, 14, 95, 60 };

            Console.WriteLine(numbers[2]);
            Console.WriteLine("Оригинална редица: " + string.Join((' '), numbers));
            numbers[3] = 10;

            Console.WriteLine("Променен елемент: " + string.Join(('-'), numbers));
            Console.WriteLine("Обхождане с for: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nОбхождане с foreach: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            SumNumbers(numbers);

            MinMaxValues(numbers);
            Console.WriteLine("Въведете редица от цели числа: ");
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Console.WriteLine("Редицата е: " + string.Join(" ", inputNumbers));
            Array.Sort(inputNumbers);
            Array.Reverse(inputNumbers);
            Console.WriteLine("Редицата е: " + string.Join(", ", inputNumbers));
        
            Array.Resize(ref numbers, numbers.Length + 4);
            Console.WriteLine("Увеличената редица е: " + string.Join(" - ", numbers));
            numbers[9] = 88;
            numbers[numbers.Length - 2] = 77;
            Console.WriteLine("Променени елементи: " + string.Join("_", numbers));
            Array.Clear(numbers);
            Console.WriteLine(string.Join(" ", numbers));

            string[] elements = new string[5]; 

            List<string> fruits = new List<string>() { "киви", "манго", "ябълка", "ябълка", "ананас"};
            fruits.Remove("киви");
            fruits.RemoveAt(0);
            fruits.RemoveAll(f => f == "ябълка");
            Console.WriteLine("Останали плодове: " + string.Join(", ", fruits));
            fruits.Add("пъпеш");
            fruits.Add("диня");
            
            Console.WriteLine("Нови плодове: " + string.Join(", ", fruits));

            List<double> numbersD = Console.ReadLine().Split().Select(double.Parse).ToList();

            MinMaxSumAvg(numbersD);
#else
            /* 1 task */
            Console.Write("Въведете цели числа: ");
            List<int> list = new List<int>();
            list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Списъкът е: " + string.Join(", ", list));
            Console.WriteLine($"Сума: {list.Sum()}, брой: {list.Count}, средна стойност: {list.Average():F3}");

#endif
            Console.WriteLine("###### КРАЙ! :) ######");
        }

        private static void MinMaxSumAvg(List<double> list)
        {
            Console.WriteLine($"Min: {list.Min()} Max: {list.Max()} Sum: {list.Sum():F2}");
        }

        private static void MinMaxValues(int[] numbers)
        {
            int min = int.MaxValue;  //numbers[0];
            int max = int.MinValue;  //numbers[0];

            foreach (int number in numbers)
            { if (number < min) min = number;
              if(number > max) max = number;
            }
            Console.WriteLine($"Min: {min} Max: {max}");
        }

        private static void SumNumbers(int[] array)
        {
            int sum = 0;

            foreach(int a in array)
            {
                sum += a;
            }
            Console.WriteLine("\nСумата е: " + sum);
        }
    }
}
