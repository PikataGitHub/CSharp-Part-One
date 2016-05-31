using System;

class BiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double max = a;

        if (a < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        if (max < d)
        {
            max = d;
        }
        if (max < e)
        {
            max = e;
        }
        Console.WriteLine(max);
    }
}