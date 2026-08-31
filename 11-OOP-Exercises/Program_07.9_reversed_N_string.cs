namespace _07._9_reversed_N_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете поредица: ");
            var items = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < items.Length / 2; i++)
            {
                var temp = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", items));
        }
    }
}
