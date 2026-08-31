


using _07._4_Methods_class;
using System.Globalization;

Separator();

MyFirstMethod();


Separator();

UserService.GreetUser("Петър");
UserService.GreetUser("Иван");



Separator();

int result = Substraction(5, 8);

int c = 10;

Substraction(result, c);

Console.WriteLine(Substraction(15,10));

Separator(); 

int Substraction(int a, int b)
{
    int difference = a - b;
    Console.WriteLine($"{a} - {b} = {difference}");
    return difference;
}


void MyFirstMethod()
{
    Console.WriteLine("Моят първи метод.");
}
void Separator()
{
    Console.WriteLine(new string('-', 30));
}