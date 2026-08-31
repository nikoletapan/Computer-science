
using System.ComponentModel;

internal class Program
{
    static int Sum(int a, int b) // връща int
    {
        return a + b;
    }
    static int Square(int a) // връща int
    {
        return a * a;
    }
    static void Print(string username) // не връща, печата
    {
        Console.WriteLine($"Hello, {username}!");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    // Това също е метод
    public static void PrintResult(int result)
    {
        Console.WriteLine($"Result: {result}");
    }

    private static void Main(string[] args)
    {
        PrintResult(5);
        Add(3, 4);

        Console.WriteLine("Методи и функции");
        string user = Console.ReadLine();
        Print(user);

        Sum(10, 20);  // извиква метод и му задава стойности
        Square(4);

        int x = Sum(20, 30); // присвоява метод на променлива
        int y = Square(5);

        Console.WriteLine(x); // печата променлива
        Console.WriteLine(Sum(30, 40)); // печата метод

        Console.WriteLine(y);   
        
    }



// Това се нарича "МЕТОД" в C#
    // Това е метод

}

