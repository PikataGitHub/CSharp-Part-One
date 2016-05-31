using System;

class PointInACirlce
{
    static void Main()
    {
        double coordinateX = double.Parse(Console.ReadLine());
        double coordinateY = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(coordinateX * coordinateX + coordinateY * coordinateY);
        if (distance <= 2)
        {
            Console.WriteLine("yes" + " " + distance.ToString("F2"));
        }
        else
        {
            Console.WriteLine("no" + " " + distance.ToString("F2"));
        }
    }
}