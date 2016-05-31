using System;

class Calculate
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        double X = double.Parse(Console.ReadLine());
        double sumS = 1 + (1 / X);

        for (ulong j = 2; j <= N; j++)
        {
            ulong factorial = 1;
            for (ulong i = 2; i <= j; i++)
            {
                factorial = factorial * i;
            }
            sumS = sumS + factorial / (Math.Pow(X, j));
        }
        Console.WriteLine("{0:F5}", sumS);
    }
}