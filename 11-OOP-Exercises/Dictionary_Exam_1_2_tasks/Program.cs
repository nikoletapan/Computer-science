namespace Dictionary
{
    /// <summary>
    /// Практическо изпитване
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1 зад: меню
            
            Bill bill = new Bill();
            bill.ShowMenu();
            bill.Choices();
            bill.ShowBill();

            Console.WriteLine("\nTHANK YOU! HAVE A NICE DAY!");

            // 2 зад. Обръщане на текст

            Reverse reverse = new Reverse();
            reverse.Reversion();
        }
    }
}
