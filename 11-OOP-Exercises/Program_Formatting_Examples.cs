Console.WriteLine("====== Теория - примери =======");
string name = "Мария";
int score = 95;
string file = "data.txt";

// 1. Интерполация ($)
Console.WriteLine($"1. Интерполация: {name} има {score} точки");

// 2. Дословно (@) 
Console.WriteLine(@"2. Verbatim: {name} има {score} точки");

// 3. Комбиниране ($@)  
Console.WriteLine($@"3. Комбиниране: {name} има {score} точки в C:\Users\{file}");

// 4. Многоредов низ с @
Console.WriteLine(@"4. Многоредов:
- Първи ред
- Втори ред
- Трети ред");

// 5. Форматиране с интерполация
double price = 12.5;
Console.WriteLine($"5. Форматиране: Цената е {price:C2}"); // Currency format
Console.WriteLine($"   Процент: {0.75:P0}"); // Percent format

Console.WriteLine("====== Първа задача =======");
/* 1 зад*/
// Вевежда се число 1 - 7 и се отпечатва денят от седмицата с думи

Console.Write("Въведете число (1-7) :");
int day = int.Parse(Console.ReadLine());

string dayName = "";

switch (day)
{
    case 1: dayName = "понеделник"; break;
    case 2: dayName = "Вторник"; break;
    case 3: dayName = "Сряда"; break;
    case 4: dayName = "Четвъртък"; break;
    case 5: dayName = "Петък"; break;
    case 6: dayName = "Събота"; break;
    case 7: dayName = "Неделя"; break;
    default: dayName = "Грешка!"; break;
}

Console.WriteLine($"Съответният ден е: {dayName}");

Console.WriteLine("====== Втора задача =======");
/* 2 зад*/
// Вевежда се число 2 - 6 и се отпечатва съответната оценка с думи

Console.Write("Въведете оценка (2-6): ");
int n = int.Parse(Console.ReadLine());

string gradeName = (n) switch
{
    2 => "Слаб",
    3 => "Среден",
    4 => "Добър",
    5 => "Много добър",
    6 => "Отличен",
    _=> "Грешка!"
};

Console.WriteLine($"Вашата оценка е: {gradeName} ({n}).");

Console.WriteLine("====== Трета задача =======");
/* 3 зад*/
// Вевежда се десетично число 2-6 и се отпечатва съответствието й с думи

Console.Write("Въведете десетична оценка: ");
double nd = double.Parse(Console.ReadLine());

string gradeNameDouble = (nd) switch
{
    >=2 and <= 2.99 => "Слаб",
    >= 3.00 and <= 3.49 => "Среден",
    >= 3.50 and <= 4.49 => "Добър",
    >= 4.50 and <= 5.49 => "Много добър",
    >= 5.50 and <= 6.00 => "Отличен",
    _=> "Грешка!"
};

Console.WriteLine($"Вашата десетична оценка е {gradeNameDouble} ({nd})");

Console.WriteLine("====== Четвърта задача - класическо решение =======");

Console.Write("Въведете десетична оценка: ");
double ndC = double.Parse(Console.ReadLine());
string gradeNameC = string.Empty;

switch (ndC)
{
    case >= 2 and <= 2.99: gradeNameC = "Слаб"; break;
    case >= 3.00 and <= 3.49: gradeNameC = "Среден"; break;
    case >= 3.50 and <= 4.49: gradeNameC = "Добър"; break;
    case >= 4.50 and <= 5.49: gradeNameC = "Много добър"; break;
    case >= 5.50 and <= 6.00: gradeNameC = "Отличен"; break;
    default: gradeNameC = "Грешка!"; break;
}

Console.WriteLine($"Вашата десетична оценка е {gradeNameC} ({ndC})");