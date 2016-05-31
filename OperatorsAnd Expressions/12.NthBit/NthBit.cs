using System;

class NthBit
{
    static void Main(string[] args)
    {
        long P = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int mask = 1 << N;

        long result = P & mask;

        long NthBit = result >> N;

        Console.WriteLine(NthBit);
    }
}