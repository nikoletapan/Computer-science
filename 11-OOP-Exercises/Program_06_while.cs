/*
string input = Console.ReadLine().ToLower();
int sum = 0, count = 0;

while(input != "stop")
{
    int n = int.Parse(input);

    if (n % 2 == 0 || n % 3 == 0)    
    {
        Console.Write(n + " ");
        sum += n;
        count++;
    }
    input = Console.ReadLine().ToLower();
}
Console.WriteLine((double)sum/count);
////////////
string input = Console.ReadLine();
int sum = 0, count = 0;
double average = 0;

while (input != "stop")
{
    int n = int.Parse(input);

    if (n % 3 == 0)
    {
        sum+=n;
        count++;
    }
    input = Console.ReadLine().ToLower();
}
average = (double) sum / count;
Console.WriteLine(average);
/////////////
// n! = n *(n-1)*(n-2)*(n-3)*...*2*1
int n = int.Parse(Console.ReadLine());

decimal factorial = 1;

// Perform an "infinite loop"
while (n>1)
{
    factorial *= n;
    n--;
}
Console.WriteLine("n! = " + factorial);
Console.WriteLine($"В момента е {DateTime.Now}");

////////////////

using System.Numerics;

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
BigInteger factorial = 1;
do
{
    factorial *= n;
    n--;
} while (n > 0);
Console.WriteLine("n! = " + factorial);
/*
//////////
///
int x = 1;

while ( x > 1)
{
    Console.WriteLine(x);
}
Console.WriteLine("Прескача");


string input = Console.ReadLine().ToLower();
int sum = 0, count = 0;
double average = 0;

while(input != "stop")
{
    int n = int.Parse(input);

    if( n % 11 == 0)
    {
        sum += n;
        count++;
    }
    input = Console.ReadLine().ToLower();
}
average = (double) sum / count;
Console.WriteLine(average);


using System.Diagnostics.CodeAnalysis;

int x = 0;

while (x > 1)
{
    Console.WriteLine(x);
    //x++;
}
Console.WriteLine("Прескача");


int n = int.Parse(Console.ReadLine());
string name = "";

if (n % 2 == 0) name = "четно";
else name = "нечетно";

//(n % 2 == 0) ? name = "четно" : name = "нечетно"; */
/*
string input =  Console.ReadLine().ToUpper();

while (input != "END")
{
    int n = int.Parse(input);

    if (n % 7 == 0)
    {
        Console.WriteLine($"{n}^2 = {n*n}");
    }
    input = Console.ReadLine().ToUpper();
}
for (int i = 0, sum = i + 1; i <= 5; i++, sum += i)
{
    Console.WriteLine("i={0}, sum={1}", i, sum);
}

// съкратен if-else (условие ? истина : иначе) 
int time = 14;
string dayTime = (time > 5 && time < 20 ? "Day" : "Night");
Console.WriteLine(dayTime);


Console.WriteLine(1 + 2 + "3" + 4 + 5);

string input = Console.ReadLine().ToUpper();

while (input != "END")
{
    int n = int.Parse(input);

    if (n % 5 == 0)
    {
        n *= 3;
        Console.WriteLine(n);
    }

    input = Console.ReadLine().ToUpper();
}
*/

for(int a = 0, b = 10, c = a + b; a < 5; a++, b--)
{
    Console.WriteLine("c = a + b = ({0} + {1}) = {2}", a, b, c);
}


