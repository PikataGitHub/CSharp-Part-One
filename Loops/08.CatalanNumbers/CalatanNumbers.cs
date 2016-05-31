using System;
using System.Numerics;

class CalatanNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        BigInteger nominator = 1;
        for (int i = (N + 2); i <= (2 * N); i++)
        {
            nominator = nominator * i;
        }
        BigInteger denominator = 1;
        for (int j = 2; j <= N; j++)
        {
            denominator = denominator * j;
        }

        BigInteger result = nominator / denominator;
        Console.WriteLine(result);
    }
}