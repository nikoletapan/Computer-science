// Top-level code
using System;

Console.WriteLine("=== ГЛАВНА ПРОГРАМА ===");
Console.Write("Въведете име: ");
string username = Console.ReadLine();
Console.Write("Въведете оценка (2.00 - 6.00): ");
double grade = double.Parse(Console.ReadLine());
DisplaySeparator(); // локална функция

UserService.GreetUser(username);
//GradeProcessor.GradeName(grade);

GradeProcessor.GradeName(3.50);
double testGrade = double.Parse(Console.ReadLine());
GradeProcessor.GradeName(testGrade);

DisplaySeparator(); //локална функция 

MathOperations.TriangleArea(3, 4);
MathOperations.CircleArea(7);

DisplaySeparator(); // локална функция
void DisplaySeparator()
{
    Console.WriteLine(new string('-', 30));
}




