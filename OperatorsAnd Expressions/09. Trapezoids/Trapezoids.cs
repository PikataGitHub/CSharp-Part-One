using System;

class Trapezoids
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double heightH = double.Parse(Console.ReadLine());

        double trapezoidArea = (sideA + sideB) * heightH / 2;

        //Console.WriteLine("{0:F7}", sideA);
        //Console.WriteLine("{0:f7}", sideB);
        //Console.WriteLine("{0:f7}", heightH);
        Console.WriteLine("{0:f7}", trapezoidArea);

    }
}