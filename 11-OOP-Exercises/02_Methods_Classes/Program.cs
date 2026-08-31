namespace _02_Methods_Classes
{
    class Calculator
    {
        public int A;
        public int B;

        public int Sum()
        {
            return A + B;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();

            Console.Write("Въведете първо число: ");
            sum.C = int.Parse(Console.ReadLine());

            Console.Write("Въведете второ число: ");
            sum.D = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумата е: " + sum.Add());


            Calculator calc = new Calculator();

            Console.Write("Въведете първо число: ");
            calc.A = int.Parse(Console.ReadLine());

            Console.Write("Въведете второ число: ");
            calc.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумата е: " + calc.Sum());

            Triangle triangle = new Triangle("ABC", 3, 4, 5);
            // triangle.name - недостъпно, защото е private

            double p = triangle.Perimeter();
            double s = triangle.Area();
            Console.WriteLine($"P = {p, -20} S = {s}");

            // ArrayReverse();

        }

        static void PrintSintaxis()
        {
            int a = 3;
            int b = 4;
            char c = 'Q';
            string name = "Georgi";

            Console.WriteLine("Old syntax {0}, {1}, {2}, {3}", a, b, c, name);
            Console.WriteLine($"Newer sintax {a}, {b}, {c}, {name}");
        }

        static void StringReverse()
        {
            string original = "Hello world!";
            string reverse = string.Empty;
            char firstLetter = original[0]; // H
            char secondLetter = original[1]; // e
            char lastLetter = original[original.Length-1]; //!

            for (int i = original.Length -1; i > 0 ; i--)
            {
                reverse = original[i].ToString();
            }
            Console.WriteLine($"{original} \n {reverse}");
        }

        static int FindMax()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b > max)
                {
                    max = b;
                }
            }
            Console.WriteLine("max = " + max);
            return max;
        }

        static int FindMin()
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "stop")
            {
                int n = int.Parse(input);

                if (n < min)
                {
                    min = n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("min = " + min);
            return min;
        }

        static void ArrayReverse()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] output = new int[input.Length];

            int j = 0;

            for (int i = input.Length-1; i>0;  i--)
            {
                output[j] = input[i];
                j++;
                
            }
            Console.WriteLine(string.Join(" "), output);
        }

        static void Crash()
        {
            Crash();
        }
    }
}
