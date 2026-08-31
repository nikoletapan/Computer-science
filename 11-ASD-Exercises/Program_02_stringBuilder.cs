using System.Text;

string shortText = "Сняг";
string longText = "Все още е зима";
string shortTextSmallCase = "сняг";

Console.WriteLine(string.Compare(shortText, longText));                  // 1
Console.WriteLine(string.Compare(shortText, shortTextSmallCase, false)); // 1
Console.WriteLine(string.Compare(shortText, shortTextSmallCase, true));  // 0

Console.WriteLine(string.Concat(longText, " и вали ", shortText.ToLower()));

Console.WriteLine(longText.LastIndexOf('е')); // индекс на последно срещане 8

Console.WriteLine("Въведете текст: ");
char[] text = Console.ReadLine().ToCharArray();
Console.WriteLine("Обърнат текст: ");
Array.Reverse(text);
Console.WriteLine(new string(text));
Console.WriteLine();

string title = "String Builder";
Console.WriteLine($"=== {title.ToUpper()} ===");
Console.WriteLine(new string('=', title.Length + 8));

StringBuilder strBuild1 = new StringBuilder();     // Нов, празен
StringBuilder strBuild2 =  new StringBuilder("Нашият първи дълъг текст!");
StringBuilder strBuild3 = new StringBuilder(100);  // първоначален капацитет

strBuild1.AppendLine("Това е първият текст, последван от празен ред.");
strBuild2.Replace("първи", "втори")
    .AppendLine(" Това е чудесно!")
    .Append("Можем да добавим булева променлива: ")
    .Append(true)
    .Append(" А също и число: ")
    .Append(42);

Console.WriteLine(strBuild1);
Console.WriteLine(strBuild2);

strBuild1.Insert(14, " интересен");
Console.WriteLine(strBuild1);

strBuild1.Remove(22, 27);    // от index 22 "интерес" премахва 27 символа до "ен ред" 
Console.WriteLine(strBuild1);

strBuild2.Clear();
Console.WriteLine("Дължина: " + strBuild2.Length);  // 0

strBuild3.AppendLine("* Достъп до символи!");
Console.WriteLine(strBuild3);
Console.WriteLine(strBuild3[0] + " Невъзможно със string!");
strBuild3[0] = '#';
Console.WriteLine(strBuild3 + " Промяната е осъществена!");

Console.WriteLine("Капацитет на първи: " + strBuild1.Capacity);
Console.WriteLine("Капацитет на втори: " + strBuild2.Capacity);
Console.WriteLine("Капацитет на трети: " + strBuild3.Capacity);

strBuild2.AppendFormat("Дата: {0:dd.MM.yyyy}, Температура: {1:F1}°C",
                DateTime.Now, -1.5);

Console.WriteLine(strBuild2);
Console.WriteLine("Капацитет на втори след промяна: " + strBuild2.Capacity);

string finalString = strBuild2.ToString();
Console.WriteLine(finalString);
