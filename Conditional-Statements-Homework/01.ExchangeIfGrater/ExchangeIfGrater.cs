using System;

class ExchangeIfGrater
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        if (A > B)
        {
            double temp = A;
            A = B;
            B = temp;
        }
        Console.Write("{0} {1}",A,B);
    }
}