using System;

class ThirdBit
{
    static void Main(string[] args)
    {

        long P = long.Parse(Console.ReadLine());

        int mask = 1 << 3;

        long result = P & mask;

        long NthBit = result >> 3;

        Console.WriteLine(NthBit);

    }
}