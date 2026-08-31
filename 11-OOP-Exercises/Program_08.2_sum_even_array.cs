namespace _08._2_sum_even_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете редица от числа: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                    sum += currentNum;
            }
            Console.WriteLine($"Сумата на четните числа е: {sum}");
        }
    }
}
