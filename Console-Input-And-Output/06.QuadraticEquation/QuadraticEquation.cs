using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double determinat = b * b - 4 * a * c;

        if (determinat < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (determinat == 0)
        {
            double X = -b / (2 * a);
            Console.WriteLine("{0:F2}", X);
        }
        else
        {
            double X1 = (-b + Math.Sqrt(determinat)) / (2 * a);
            double X2 = (-b - Math.Sqrt(determinat)) / (2 * a);
            Console.WriteLine("{0:F2}", Math.Min(X1, X2));
            Console.WriteLine("{0:F2}", Math.Max(X1, X2));
        }
    }
}