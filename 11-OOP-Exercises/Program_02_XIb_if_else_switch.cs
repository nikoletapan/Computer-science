Console.Write("Въведете час (0 - 23): ");
int hour = int.Parse(Console.ReadLine());
Console.Write("Въведете ден (1 - 31): ");
int day = int.Parse(Console.ReadLine());
Console.Write("Въведете месец (1 - 12): ");
int month = int.Parse(Console.ReadLine());

if (day >= 29 && month == 2)
{
    Console.WriteLine("Некоректни данни!");
    return;
}

Console.Write("Въведете година: ");
int year = int.Parse(Console.ReadLine());



//string holiday = "";

//if (day == 1 && month == 1) holiday = "Нова година!";
//else if (day == 3 && month == 3) holiday = "Освобождението!";
//else if (day == 1 && month == 6) holiday = "Ден на детето!";
//else if (day == 15 && month == 9) holiday = "Начало на учебната година!";
//else holiday = "Обикновен ден";

// Ctrl + K + C = Comment
// Ctrl + K + U = UnComment

string holiday = (day, month) switch
{
    (1, 1) => "Нова година!",
    (3, 3) => "Освобождение!",
    (1, 6) => "Ден на детето!",
    (15, 9) => "Начало на учебната година!",
    _=> "Обикновен ден."
};

Console.WriteLine($"Това е празник - {holiday}");

string monthName = string.Empty; // еквивалентно на ""

switch (month)
{
    case 1: monthName = "януари"; break;
    case 2: monthName = "февруари"; break;
    case 3: monthName = "март"; break;
    case 4: monthName = "април"; break;
    case 5: monthName = "май"; break;
    case 6: monthName = "юни"; break;
    case 7: monthName = "юли"; break;
    case 8: monthName = "август"; break;
    case 9: monthName = "септември"; break;
    case 10: monthName = "октомври"; break;
    case 11: monthName = "ноември"; break;
    case 12: monthName = "декември"; break;
    default: Console.WriteLine(); break;
}

Console.WriteLine($"Това е месец {month}, който се казва {monthName}");

string  season = string.Empty;

if ((day >= 20 && month >= 3) && (day <= 21 && month <= 6))
    season = "пролет";
else if ((day > 21 && month >= 6) && (day <= 22 && month <= 9))
    season = "лято";

Console.WriteLine($"Сезонът е {season}");