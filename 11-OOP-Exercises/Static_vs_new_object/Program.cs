namespace Static_vs_new_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recursion.Crash();

            Country country1 = new Country();
            Console.Write("Въведете име на държава: (България)");
            country1.Frequency();
        }
    }
}
