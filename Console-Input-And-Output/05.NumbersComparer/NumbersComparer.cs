using System;

class NumbersComparer
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double C = Math.Max(A, B);
        Console.WriteLine(C);
    }
}