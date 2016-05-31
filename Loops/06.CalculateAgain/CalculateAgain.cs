using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long K = long.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        for (long i = N; i >= (K + 1); i--)
        {
            factorial = factorial * i;
        }
        Console.WriteLine(factorial);
    }
}