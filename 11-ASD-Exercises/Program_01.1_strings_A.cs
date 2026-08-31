namespace _01._1_strings_A_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "Вчера";
            string second = "валеше";
            string third = "сняг";

            string fourth = first + " " + second + " " + third + '!';

            Console.WriteLine(fourth);

            int firstLength = first.Length;

            Console.WriteLine(firstLength);  // 5

            Console.WriteLine(second.Length); // 6

            Console.WriteLine(new string('-', 33));

            Console.WriteLine(third[0]);  // с - първа
            Console.WriteLine(third[1]);  // н
            Console.WriteLine(third[2]);  // я
            Console.WriteLine(third[3]);  // г

            Console.WriteLine(new string('-', 33));

            Console.WriteLine(third.Length);  // 4
            Console.WriteLine(third[third.Length-1]); // 4 - 1 = 3

            Console.WriteLine(first.ToUpper());
            Console.WriteLine("онлайн обучение".ToUpper());

            Console.WriteLine(new string('-', 33));
            Console.WriteLine("Математика".Substring(4));    // матика
            Console.WriteLine("Математика".Substring(0, 4)); // Мате

            Console.WriteLine(new string('-', 33));
            string asd = "Структури от данни и алгоритми";
            Console.WriteLine(asd.Contains("данни"));
            Console.WriteLine(asd.IndexOf("данни"));  // 13
            Console.WriteLine(asd.Remove(13, 6));   // отстранихме "данни" + интервал

            Console.WriteLine(fourth.Replace("сняг", "дъжд"));

            string[] names = { "Мария", "биология", "5.50"};
            Console.WriteLine(names.Length);
            Console.WriteLine(string.Join('-', names));

 
        }
    }
}
