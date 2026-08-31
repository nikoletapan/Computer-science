using System.Reflection.Metadata.Ecma335;

Console.Write("Въведете час (0 - 23): ");
int hour = int.Parse(Console.ReadLine());
Console.Write("Въведете ден (1 - 31): ");
int day = int.Parse(Console.ReadLine());
Console.Write("Въведете месец (1-12): ");
int month = int.Parse(Console.ReadLine());

if (day >= 30 && month == 2)
{
    Console.WriteLine("Некоректни данни!");
    return;
}
Console.Write("Въведете година: ");
int year = int.Parse(Console.ReadLine());



//string holiday = "";

//if (day == 1 && month == 1) holiday = "Нова година!";
//else if (day == 3 && month == 3) holiday = "Освобождение!";
//else if (day == 6 && month == 5) holiday = "Гергьовден!";
//else if (day == 15 && month == 9) holiday = "Начало на учебната година!";
//else holiday = "Обикновен ден.";

string holiday = (day, month) switch
{
    (1, 1) => "Нова година!",
    (3, 3) => "Освобождение!",
    (6, 5) => "Гергьовден!",
    _=> "Обикновен ден"
};


Console.WriteLine($"Това е празник - {holiday} ."); // интерполация

//string monthName = string.Empty;

//switch (month)
//{
//    case 1: monthName = "януари"; break;
//    case 2: monthName = "февруари"; break;
//    case 3: monthName = "март"; break;
//    case 4: monthName = "април"; break;
//    case 5: monthName = "май"; break;
//    case 6: monthName = "юни"; break;
//    case 7: monthName = "юли"; break;
//    case 8: monthName = "август"; break;
//    case 9: monthName = "септември"; break;
//    case 10: monthName = "октомври"; break;
//    case 11: monthName = "ноември"; break;
//    case 12: monthName = "декември"; break;
//    default: monthName = "Некоректни данни!"; break;
//}

string monthName = (month) switch // модерен switch
{ 1 => monthName = "януари",
  2 => "февруари",
  3 => "март",
  4 => "април",
  5 => "май",
  6 => "юни",
  7 => "юли",
  8 => "август",
  9 => "септември",
  10 => "октомври",
  11 => "ноември",
  12 => "декември",
  _=> "Невалиден месец!"
};

Console.WriteLine($"Това е месец {month}, " +
    $"който се казва {monthName}.");

// Ctrl + R + R = replace and rename

string seasonName = ""; 

if ((day >= 20 && month >= 3) && (day < 21 && month <= 6))
    seasonName = "пролет";
else if ((day >= 21 && month >= 6) && (day < 22 && month <= 9))
    seasonName = "лято";
else if ((day >= 23 && month >= 9) && (day < 21 && month <= 12))
    seasonName = "есен";
else seasonName = "зима";

Console.WriteLine($"Сезонът е {seasonName}!");


