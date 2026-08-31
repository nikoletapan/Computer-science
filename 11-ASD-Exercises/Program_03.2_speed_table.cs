using System;
using System.Text;
using System.Diagnostics;

class PerformanceTest
{
    static void Main()
    {
        int[] tests = { 1000, 5000, 10000, 50000 };

        Console.WriteLine("Сравнение на производителността:");
        Console.WriteLine("N\t\tString (ms)\tStringBuilder (ms)");
        Console.WriteLine(new string('-', 50));

        foreach (int n in tests)
        {
            // Тест със string
            Stopwatch sw1 = Stopwatch.StartNew();
            BuildWithString(n);
            sw1.Stop();

            // Тест със StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            BuildWithStringBuilder(n);
            sw2.Stop();

            Console.WriteLine($"{n}\t\t{sw1.ElapsedMilliseconds}\t\t{sw2.ElapsedMilliseconds}");
        }
    }
    static string BuildWithString(int n)
    {
        string result = "";
        for (int i = 1; i <= n; i++)
        {
            result += i + ","; // Зле за производителност!
        }
        return result;
    }

    static string BuildWithStringBuilder(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            sb.Append(i).Append(","); // Добре за производителност!
        }
        return sb.ToString();
    }

}