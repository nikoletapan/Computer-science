namespace _08._1_equal_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arr1.Length != arr2.Length)
                Console.WriteLine($"Редиците са с различна дължина!");

            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Редиците са различни  в позиция {i}.");
                    return;
                }
                else
                    sum += arr1[i];
            }
            Console.WriteLine($"Редиците са идентични. Тяхната сума е: {sum}");
        }
    }
}
