using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        BigInteger nominator = 1;
        for (int i = (K + 1); i <= N; i++)
        {
            nominator = nominator * i;
        }
        BigInteger denominator = 1;
        for (int j = 1; j <= (N - K); j++)
        {
            denominator = denominator * j;
        }

        BigInteger result = nominator / denominator;
        Console.WriteLine(result);
    }
}