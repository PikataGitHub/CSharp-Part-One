using System;

class MultiplicationSign
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        if (A == 0 || B == 0 || C == 0)
        {
            Console.WriteLine(0);
        }
        if (A < 0 && B < 0 && C < 0)
        {
            Console.WriteLine("-");
        }
        if (A < 0 && B < 0 && C > 0)
        {
            Console.WriteLine("+");
        }
        if (A < 0 && B > 0 && C < 0)
        {
            Console.WriteLine("+");
        }
        if (A < 0 && B > 0 && C > 0)
        {
            Console.WriteLine("-");
        }
        if (A > 0 && B < 0 && C < 0)
        {
            Console.WriteLine("+");
        }
        if (A > 0 && B < 0 && C > 0)
        {
            Console.WriteLine("-");
        }
        if (A > 0 && B > 0 && C < 0)
        {
            Console.WriteLine("-");
        }
        if (A > 0 && B > 0 && C > 0)
        {
            Console.WriteLine("+");
        }
    }
}