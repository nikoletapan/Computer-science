namespace Exam2_methods_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Separator();
            OrderMenu();
            Separator();
            Order.Choice();
            Separator();
            Reverse.Name();
            Separator();
            Console.WriteLine($"{DateTime.Now}");
        }

        static void Separator()
        {
            Console.WriteLine(new string('-', 30));
        }

        static void OrderMenu()
        {
            Console.WriteLine(@"Choose in BGN:
C) coffee: 0.80 
W) water: 1.70
M) milk: 1.20
J) juice: 1.50");
        }
    }
}
