namespace _01._1_strings_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // char ''

            string first = "Вчера";
            string second = "валя";
            string third = "сняг";
            char symbol = '!';

            string fourth = first + " " + second + ' ' + third + symbol;
            Console.WriteLine(fourth);

            Console.WriteLine("Дължината на думата сняг е " + third.Length + " символа"); // 4

            Console.WriteLine(third[0]); // 0 - винаги първи
            Console.WriteLine(third[1]); // как да хвана Н
            Console.WriteLine(third[2]);
            Console.WriteLine(third[3]); // последен .Length-1

            Console.WriteLine(new string('-', 33));

            Console.WriteLine(third[third.Length-1]); // винаги хваща последния

            Console.WriteLine("Онлайн обучение".Length);

            Console.WriteLine("Онлайн обучение".Substring(7)); //обучение
            Console.WriteLine("Онлайн обучение".Substring(0, 5)); // Онлайн

            Console.WriteLine(fourth.Contains("сняг"));  // True
            Console.WriteLine(fourth.IndexOf("сняг"));   // index 11

            Console.WriteLine(fourth.Replace("сняг", "дъжд"));
            Console.WriteLine("Парола".Replace('а', '@'));

            Console.WriteLine("Онлайн обучение по информатика".Remove(0, 7));

            Console.WriteLine(new string('-', 33));

            string[] longText = { "Това", "е", "дълъг", "текст"};
            Console.WriteLine(string.Join(' ', longText));
        }
    }
}
