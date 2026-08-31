namespace _02_timer
{
    using System;
    using System.Text;
    using System.Diagnostics; 

    internal class Program
    {
        static void Main()
        {
            int count = 50000;

            // МЕТОД 1: Със string (бавно)
            Stopwatch timer = Stopwatch.StartNew();
            string result1 = "";
            for (int i = 0; i < count; i++)
            {
                result1 += i.ToString() + " ";
            }
            timer.Stop();
            Console.WriteLine($"String време: {timer.ElapsedMilliseconds} мс");

            // МЕТОД 2: Със StringBuilder (бързо)
            timer.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(i).Append(" ");
            }
            string result2 = sb.ToString();
            timer.Stop();
            Console.WriteLine($"StringBuilder време: {timer.ElapsedMilliseconds} мс");

            // Разликата може да е ДЕСЕТКИ пъти!
        }
    }
}
