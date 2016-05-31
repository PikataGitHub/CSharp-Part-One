using System;

class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());

        if (v == 1)
        {
            ulong mask = (ulong)1 << P;
            N = N | mask;
            Console.WriteLine(N);
        }
        else
        {
            ulong mask = ~((ulong)1 << P);
            N = N & mask;
            Console.WriteLine(N);
        }
    }
}