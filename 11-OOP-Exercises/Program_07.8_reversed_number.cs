namespace _07._8_reversed_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой редове: ");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете всяко число на нов ред: ");

            int[] numbers = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
