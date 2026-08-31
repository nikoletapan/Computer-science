using System.Threading.Channels;

namespace Lists_VS_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3]; // фиксиран размер

            List<string> trees = new List<string>(); // Мн. ч., празен списък, може да расте

            List<int> numbers = new List<int>() { 4, 7, 9, 12 }; // Със стойности
            List<string> fruits = new List<string>() { "ябълка", "круша", "ягода", "диня" };
            Console.WriteLine("Оригинален списък с плодове: " + string.Join(", ", fruits));
            fruits[2] = "череша"; // ягода -> череша
            fruits.Add("липа");     // Добавя в края
            fruits.Remove("круша"); //Премахва първото съвпадение
            fruits.RemoveAt(2);
            fruits.RemoveAll(f => f == "диня"); //всички съвпадения

            Console.WriteLine("Променен списък с плодове: " + string.Join(", ", fruits));

            int index = fruits.IndexOf("ябълка"); //връща 0-позиция
            Console.Write("Списъкът съдържа ли ябълка? ");
            bool apple = fruits.Contains("ябълка"); // true
            Console.Write((apple) ? "да" : "не");

            Console.WriteLine("\nВъведете редица с десетични числа: ");
            List<double> elements = Console.ReadLine().Split().Select(double.Parse).ToList();

            FindNumbers(elements);

            GenerateRandom();
        }

        private static void GenerateRandom()
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(random.Next(1, 101));
            }

            Console.WriteLine("Случайни числа: " + string.Join(", ", randomNumbers));
            randomNumbers.Sort();
            randomNumbers.Reverse();
            Console.WriteLine("В намаляващ ред: " + string.Join(", ", randomNumbers));
            Console.WriteLine("Сума: " + randomNumbers.Sum());
        }

        private static void FindNumbers(List<double> elements)
        {
            double sum = 0.0;

            foreach (double element in elements) 
                sum += element;

            Console.WriteLine($"Сумата на редицата: {string.Join('+', elements)} = {sum:F2}");
            Console.WriteLine($"Мин: {elements.Min()} Макс: {elements.Max()}");
        }
    }
}
