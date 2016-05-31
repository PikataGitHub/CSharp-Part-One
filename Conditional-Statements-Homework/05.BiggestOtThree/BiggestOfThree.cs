using System;

class BiggestOfThree
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double temp = Math.Max(A, B);
        Console.WriteLine(Math.Max(temp,C));
    }
}