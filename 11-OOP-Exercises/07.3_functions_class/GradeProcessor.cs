using System;

public static class GradeProcessor
{
    public static void GradeName(double grade)
    {
        string gradeName = GetGrade(grade);
        Console.WriteLine($"Оценка: {gradeName} ({grade}) ");
    }
        public static string GetGrade(double grade)
    {
        return grade switch
        {
            >= 5.50 => "Отличен",
            >= 4.50 and <= 5.49 => "Много добър",
            >= 3.50 and <= 4.49 => "Добър",
            >= 2.99 and <= 3.49 => "Среден",
            _ => "Слаб"
        };
    }
}