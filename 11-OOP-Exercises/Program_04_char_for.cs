using System.Threading.Channels;
/*
// Пример за char в switch
Console.WriteLine("Изберете буква:");

char letter = char.Parse(Console.ReadLine());
string letterChoice = "";

switch (letter)
{
    case 'a': letterChoice = "първи избор"; break;
    case 'b': letterChoice = "втори избор"; break;
    default: letterChoice = "Грешка!"; break;
}

///////////////////////
// Втори начин за char в switch

string letterC1 = (letter) switch
{
    'a' => letterChoice = "първи избор",
    'b' => letterChoice = "втори избор",
    _=> letterChoice = "грешка!"
};

////////////////////
//Подредена таблица за умножение втори начин

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{j} * {i} = {i*j}\t");
    }
    Console.WriteLine();
} 

//////////////////
// Да се познае дали е въведена главна или малка буква

Console.Write("Enter a character: ");
char letter = char.Parse(Console.ReadLine());

if (letter >= 65 && letter <= 90)
    Console.WriteLine("upper-case");
else if (letter >= 97 && letter <= 122)
    Console.WriteLine("lower-case");

////////////////
// Да се въведат 2 числа и изпишат символите между тях от ASCII

Console.WriteLine("Въведете 2 числа между 0 и 127: ");
int firstChar = int.Parse(Console.ReadLine());
int lastChar = int.Parse(Console.ReadLine());

for (int i = firstChar; i <= lastChar; i++)
{
    Console.Write((char)i + " ");
}

/////////////////
// Да се въведе буква като избор и допише с думи оценката

Console.Write("Choose grade letter: ");
char letter = char.Parse(Console.ReadLine());

string grade = (letter) switch
{
    'a' => "Excellent!",
    'b' => "Very good!",
    'c' => "Good!",
    'd' => "Average.",
    'f' => "Fail.",
    _=> "Error!" 
};

Console.WriteLine($"Your grade is {grade}");

/////////////////
// Да се изчисли часа след 15 минути

Console.Write("Enter hour (0-23): ");
int hour = int.Parse(Console.ReadLine());

Console.Write("Enter minutes (0-59): ");
int minutes = int.Parse(Console.ReadLine());

int totalTime = hour * 60 + minutes + 15;  

hour = totalTime / 60;
hour %= 24;      // остатък при деление със себе си за над 24 часа 
minutes = totalTime % 60;

Console.WriteLine($"After 15 min, the time will be {hour:D2}:{minutes:D2}");



Console.Write("Enter numbers: ");
string input = Console.ReadLine();
int sumOdd = 0;
int sumEven = 0;
int sumTotal = 0;

while (input != "stop")
{
    int n = int.Parse(input);

    if (n % 2 == 0)
    { 
        sumEven += n;
    }
    else 
         sumOdd += n;

    sumTotal += n;

    input = Console.ReadLine();
}
Console.WriteLine($"The sum is {sumOdd}");

*/

// едноредов коментар

/* - поставяме в началото на кода
 за многоредов коментар
край */


