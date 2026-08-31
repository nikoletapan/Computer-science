using System;

public static class MathOperations
{
    public static double TriangleArea(double baseLength, double height)
    {
        double area = 0.5 * baseLength * height;
        Console.WriteLine($"Лице на триъгълник с дължина на основата {baseLength} и височина {height} = {area:F2}");
        return area;
    }

    public static double CircleArea(double r)
    {   
        double area = Math.PI * r * r;
        Console.WriteLine($"Лице на кръг с радиус {r} = {area:F2}");
        return area; 
    }
}