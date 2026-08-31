using System.Reflection.Metadata.Ecma335;

static void MathFunctions()
{
    // Вградени математически функции, които се използват често
    int a = 2;
    int b = 3;
    double c = 4.5;
    double d = 5.6;

    int e = int.MinValue; // най-малкото възможно число int (при сортиране)
    int f = int.MaxValue; // най-голямото възможно int

    int min = int.Min(a, b); // по-малкото от 2 числа
    int max = int.Max(a, b);
    int abs = int.Abs(a); // Absolute, абсолютна стойност, модул - без +-
    double minD = Math.Min(c, d);
    double maxD = Math.Max(c, d);
    double absD = Math.Abs(c);
    double Pi = Math.PI; // 3.14 с точност до 16-я знак след ,
    double round = Math.Round(c); // закръгля със стандартна точност 0.5
    double round2 = Math.Round(c, a); // закръгля до а-брой знаци след запетаята
    double floor = Math.Floor(c); // (под) закръгля към по-малкото число 3.7 -> 3.0
    double ceiling = Math.Ceiling(c); // (таван) закръгля към по-гомялото число 4.2 -> 5
    double squareRoot = Math.Sqrt(a); // корен квадратен
    double powered = Math.Pow(a, b); // степенуване a ^ b
    double sinus = Math.Sin(c);
    double cosus = Math.Cos(c);

Console.WriteLine($@"
a = {a}
b = {b}
c = {c}
d = {d}

e = int.MinValue = {e}
f = int.MaxValue = {f}

int.Min(a,b) = {min} 
int.Max(a,b) = {max}
int.Abs(a) = {abs}
Math.Min(c,d) = {minD}
Math.Max(c,d) = {maxD}
Math.Abs(c) = {absD}
Math.PI = {Pi}
Math.Round(c) = {round} 
Math.Round(c, a) = {round2}
Math.Floor(c) = {floor}
Math.Ceiling(c) = {ceiling} 
Math.Sqrt(a) = {squareRoot}
Math.Pow(a, b) = {powered}
Math.Sin(c) = {sinus}
Math.Cos(c) = {cosus}
");
}
static void Circle(double r) 
{ 
double perimeter = 2 * Math.PI * r;
double surface = Math.PI * Math.Pow(r,2); //3.14 * r * r
//double volume = (double)4/3 * Math.PI * Math.Pow(r,3); - for sphere

double perimeterRound = Math.Round(perimeter);
double perimeterRound3Digits = Math.Round(perimeter, 3);
double surfaceRound = Math.Round(surface);


Console.WriteLine($@" === Results ===
Perimeter = {perimeter}
Perimeter rounded = {perimeterRound}
Perimeter ROUNDED 3 digits = {perimeterRound3Digits}
Perimeter FORMATED 3 digits = {perimeter:F3}

Surface = {surface}
");
}

static void PrintMultiplicationTable(int n)
{
    for (int i = 1; i <= n; i++) Console.WriteLine($"{n} x {i} = {n*i}");
}

Console.WriteLine("========== Math Functions ==========");

MathFunctions();

Console.WriteLine("========== END ==========");

Console.Write(@"Do you want to continue?
Y/N: ");
char answer = char.Parse(Console.ReadLine());
if (answer == 'N' || answer == 'n') return; // ранен край
else
{
    Console.Write("Enter radius r = ");
    double r = double.Parse(Console.ReadLine());
    int a = 7;

    Circle(a);

    Circle(21);

    double test = 1.5;

    Circle(test);

    Circle(8);
}
Console.WriteLine("========== END =========="); // само след Yes

PrintMultiplicationTable(5);
