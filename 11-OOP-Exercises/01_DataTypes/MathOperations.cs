using System;

public static class MathOperations
{
    public static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Лице на кръг с радиус {radius}: {area:F2}");
        return area;
    }

    public static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}