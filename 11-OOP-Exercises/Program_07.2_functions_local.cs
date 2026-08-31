// Top-level code 
Console.WriteLine("=== Локални функции ===");
Console.Write("Въведете име: ");
string name = Console.ReadLine();
GreetUser(name);
Substraction(8, 5);
Console.WriteLine($"Факториел от 5: {Factorial(5)}");

void GreetUser(string userName)
{
    Console.WriteLine($"Здравей, {userName}!");
}

int Substraction(int a, int b)
{
    int difference = a - b;
    Console.WriteLine($"{a} - {b} = {difference}");
    return difference;
}

int Factorial(int n) // Рекурсия - извиква сама себе си
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}

