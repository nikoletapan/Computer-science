using System.Timers;

// Условия от г-жа В. Маринова 

Console.WriteLine("=== FOR ЦИКЪЛ ===");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"i = {i}");
}

Console.WriteLine("\n=== WHILE ЦИКЪЛ ===");
int j = 0;
while (j < 5)
{
    Console.WriteLine($"j = {j}");
    j++;
}
//////////////
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
/////////
// ОПАСНО - може да стане безкраен цикъл
int x = 0;
while (x < 10)
{
    Console.WriteLine(x);
    // Забравихме x++ - БЕЗКРАЕН ЦИКЪЛ!
}
// 1 зад: Ако а > b да ги размени
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    int temp = a; 
    a = b; 
    b = temp;
}
Console.WriteLine($"a = {a}, b = {b}");

// Сортирайте 3 реални числа в нарастващ ред. 
Console.Write("c = "); int c = int.Parse(Console.ReadLine());
Console.Write("d = "); int d = int.Parse(Console.ReadLine());
Console.Write("e = "); int e = int.Parse(Console.ReadLine());

if (c <= d)
{
    if (d <= e) Console.WriteLine($"c <= d <= e"); 
    else Console.WriteLine($"c <= e <= d");
}
else if (d <= e) 
{
    if (e <= c) Console.WriteLine($"d <= e <= c");
    else Console.WriteLine($"d <= c <= e");
}
else if (e <= c)
{
    if (c <= d) Console.WriteLine($"e <= c <= d");
    else Console.WriteLine($"e <= d <= c");
}
//



// Всички вариации без повторения на 6 от 49 - подредбата има значение.
// При комбинациите редът няма значение и се брои по веднъж.

for (int i1 = 1; i1 <= 44; i1++)
{
    for (int i2 = i1 + 1; i2 <= 45; i2++)
    {
        for (int i3 = i2 + 1; i3 <= 46; i3++)
        {
            for (int i4 = i3 + 1; i4 <= 47; i4++)
            {
                for (int i5 = i4 + 1; i5 <= 48; i5++)
                {
                    for (int i6 = i5 + 1; i6 <= 49; i6++)
                    {
                        Console.WriteLine(i1 + " " + i2 + " " +
                                 i3 + " " + i4 + " " + i5 + " " + i6);
                    }
                }
            }
        }
    }
}


