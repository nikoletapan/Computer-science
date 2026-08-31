using System;

public static class ScoreProcessor
{
    public static void ProcessScore(int score)
    {
        string grade = GetGrade(score);
        Console.WriteLine($"Резултат: {score} точки - {grade}");
    }

    private static string GetGrade(int score)
    {
        return score switch
        {
            >= 90 => "Отличен",
            >= 80 => "Много добър",
            >= 70 => "Добър",
            >= 50 => "Среден",
            _ => "Слаб"
        };
    }
}