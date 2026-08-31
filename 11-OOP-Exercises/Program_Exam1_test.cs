
///////////////////// 
/*
Console.WriteLine("Please enter two numbers(A and B), A should be <= B.");
int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
if (numbers[0] > numbers[1])
{
    throw new Exception("The second number is smaller");
}
Console.WriteLine("Here are all the numbers from A to B:");
int sum = 0;
for (int i = numbers[0]; i <= numbers[1]; i++)
{
    Console.Write(" " + i);
    sum += i;
}
Console.WriteLine();
Console.WriteLine("Here is the sum of all the numbers from A to B: " + sum); */
////////////
///
/*
Console.WriteLine("Въведете естествено число: ");
int n = int.Parse(Console.ReadLine());
double sum = 0;
int count = 0;

for (int i = n; i > 0; i--)
{
    Console.Write(i + " ");
    sum += i;
    count1++;
}
Console.WriteLine($"Средната сума е {sum/count}");

Console.WriteLine("Въведете естествено число: ");
int n = int.Parse(Console.ReadLine());
double sum = 0;
int count = 0;

while (n > 0)
{
    Console.Write(n + " ");
    n--;
    sum += n;
    count++;
}
Console.WriteLine($"Средната сума е {sum / count}"); 
//////////////
///
Console.WriteLine("Enter numbers:");
int input = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
while (input != 0)
{
    if (input > 0)
    {
        sum += input;
        count++;
    }
    input = int.Parse(Console.ReadLine());
}
Console.WriteLine($"The sum of the positive numbers is {sum}");
Console.WriteLine($"The count of the positive numbers is {count}");

//Задача 2 Д ------------------

Console.Write("Въведете цяло число, за да определите броя на числата в редицата: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

int countEven = 0;
int sumOdd = 0;

Console.WriteLine("Моля, въведете " + N + " числа:");
for (int i = 0; i < N; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        countEven++;
    }
    else
    {
        sumOdd += num;
    }
}

Console.WriteLine();
Console.WriteLine($"Броят на четните числа е: {countEven}");
Console.WriteLine($"Сумата на нечетните числа е: {sumOdd}");

//Console.WriteLine("Enter a number from 1 to 4");
//int number = int.Parse(Console.ReadLine());
//string a = string.Empty;
//switch (number)
//{
//	case 1: a="Morning"; break;
//	case 2: a = "Afternoon"; break;
//	case 3: a = "Evening"; break;
//	case 4: a = "Night"; break;
//	default: a = "Error!"; break;

//}
//Console.WriteLine($"It is {a}");

*/

//Console.WriteLine("Въведете число от (1-4):");
//int life = int.Parse(Console.ReadLine());
//string lifeName = "";
//switch (life)
//{
//	case 1: lifeName = "Seed"; break;
//	case 2: lifeName = "Sprout "; break;
//	case 3: lifeName = "Mature"; break;
//	case 4: lifeName = "Flowering"; break;
//	default: lifeName = "error"; break;
//}
//Console.WriteLine($"съответния цикъл на живота на растението :{lifeName}");










