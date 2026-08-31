using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Въведете час (0-23): ");
int hour = int.Parse(Console.ReadLine());

Console.Write("Въведете ден (1-31) : ");
int day = int.Parse(Console.ReadLine());    // Ctrl + R + R = replace all

Console.Write("Въведете месец (1-12) : ");
int month = int.Parse(Console.ReadLine());

if (day > 29 && month == 2)
{
    Console.WriteLine("Месец февруари има до 29 дена!");
    return;
}


Console.Write("Въведете година: ");
int year = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- Резултати ---");

//string holiday = string.Empty; // едно и също като ""

//if (day == 1 && month == 1) holiday = "Нова година!";     // проверява всяко
//else if (day == 3 && month == 3) holiday = "Освобождението на България!";
//else if (day == 1 && month == 6) holiday = "Денят на детето!";
//else if (day == 15 && month == 9) holiday = "Начало на учебната година!";
//else if (day == 24 && month == 12) holiday = "Бъдни вечер";
//else holiday = "Обикновен ден.";

string holiday = (day, month) switch
{
    (1, 1) => "Нова година!",
    (3, 3) => "Освобождение!",
    (1, 6) => "Ден на детето!",
    (15, 9) => "Начало на учебната година!",
    _=> "Обикновен ден."
};

string monthName = string.Empty;

switch(month)    // стар, класически метод, много лесен
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
    default: monthName = "извън диапазона"; break;
}


string season = ""; // инициализираме празен низ

if ((day >= 20 && month == 3) || (month > 3 && month < 6) ||(day < 21 && month == 6)) season = "Пролет"; 
else if ((day >= 21 && month == 6) || (month > 6 && month < 9) || (day < 22 && month == 9)) season = "Лято";
else if ((day >= 22 && month == 9) || (month > 9 && month < 12) || (day < 21 && month == 12)) season = "Есен";
else season = "Зима";

string description = "";

switch (season)
{
    case "пролет":
    case "лято": description = "топло време"; break;
    case "есен":
    case "зима": description = "студено време"; break;
    default: description = "Непознат сезон"; break;

}

Console.WriteLine(description);

string native = "";

switch (month)
{
    case 5:
    case 6:
    case 7:
    case 8: native = "Не присъства буквата \"р\" в името на месеца"; break; 
    default: native = "Денят е къс."; break;
}

Console.WriteLine(native);

switch (month)
{
    case >= 5 and <= 8: native = "Не присъства буквата \"р\" в името на месеца"; break;
    default: native = "Денят е къс."; break;
}

Console.WriteLine(native);

string timeOfDay = hour switch  
{
   >= 5 and < 12 => "Сутрин",
   >= 12 and < 17 => "Обед",
   >= 17 and < 21 => "Вечер",
   >= 21 or < 5 => "Нощ",
};

Console.WriteLine($"Час {hour:00}:00 е {timeOfDay}"); 

bool isLeapYear;

if (year % 4 == 0) isLeapYear = true;
else isLeapYear = false;

string leap = string.Empty;

if (isLeapYear) leap = "високосна";
else leap = "невисокосна";

Console.WriteLine($"Датата {day:00}.{monthName}.{year} е {timeOfDay}, {season}, {leap} година - {holiday}"); //интерполация
Console.WriteLine(native);
Console.WriteLine("Желаем хубав и спокоен ден! ");


    