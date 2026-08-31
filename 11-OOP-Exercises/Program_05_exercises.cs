
// Вписване с парола

string password = "$3cr3tP@ssw0rd"; 
Console.Write("Enter username:");
string username = Console.ReadLine();

for (int i = 5; i > 0; i--)
{
    Console.Write("Enter password: ");
    string passwordGuess = Console.ReadLine();

    if (passwordGuess == password)
    {
        Console.WriteLine($"Welcome, {username}!"); break; ;
    }
    else
        Console.WriteLine($"Wrong password! you have {i-1} more attempts!");
}
/*
///////////////////////

double speed = double.Parse(Console.ReadLine());

if (speed <= 30)
{
    Console.WriteLine("slow");
}
else if (speed > 30 && speed <= 60)
{
    Console.WriteLine("average");
}
else if (speed > 60 && speed <= 90)
{
    Console.WriteLine("fast");
}
else if (speed > 90 && speed <= 120)
{
    Console.WriteLine("ultra fast");
}
else
    Console.WriteLine("extremely fast");

////////////////////////

Console.WriteLine(@"Choose a symbol:
s for square;
r for rectangle;
c for circle;
t for triangle;");

char figure = char.Parse(Console.ReadLine());
double a, b, r, h, area = 0;

switch (figure)
{
    case 's': a = double.Parse(Console.ReadLine()); area = a * a; break;
    case 'r': a = double.Parse(Console.ReadLine());
              b = double.Parse(Console.ReadLine()); area = a * b; break;
    case 'c': r = double.Parse(Console.ReadLine()); area = r * r * Math.PI; ; break;
    case 't': a = double.Parse(Console.ReadLine());
              h = double.Parse(Console.ReadLine()); area = a * h / 2; break;
}

Console.WriteLine($"{area:F3}");

////////////////////////

Console.Write("Въведете цифра (0-9): ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 10 == n)
    {
        Console.WriteLine(i);
        sum += i;
    }
}
Console.WriteLine($"Сумата им е {sum}");

///////////////////////////
////////////
for (int i = 0; i < 10; i++)
{

    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}
string input = Console.ReadLine();
int sumPrime = 0;
int sumNonPrime = 0;

while (input != "stop")
{
    int num = int.Parse(input);

    if (num < 0)
    {
        Console.WriteLine("Number is negative.");
        input = Console.ReadLine();
        continue;
    }

    bool isPrime = true;

    for (int i = 2; i < num; i++)
    {
        if (num % (i/2) == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
        sumPrime += num;
    else
        sumNonPrime += num;

    input = Console.ReadLine();
}
Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

/////////////////

// Enter a positive integer number:
uint number = uint.Parse(Console.ReadLine());
uint divisor = 2;
uint maxDivisor = (uint)Math.Sqrt(number);
bool isPrime = true;

while (isPrime && (divisor <= maxDivisor))
{
    if (number % divisor == 0)
    {
        isPrime = false;
    }

    divisor++;
}

Console.WriteLine($"Prime? {isPrime}");
///////////
Console.WriteLine(1 + 1 + "4" + 2 + 1);  // 2421 - ?
*/

