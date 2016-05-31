using System;

class BitSwap
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        int p = 3;
        int q = 24;
        int k = 3;//Number of bits to be changed
        long mask;
        long[] bitsQK = new long[k];
        long[] bitsPK = new long[k];
        long result;//temp variable


        //Get bits {q, q+1, ... , q+k-1} and saves them to array
        for (int i = 0; i <= (k - 1); i++)
        {
            mask = (long)1 << (q + i);
            result = N & mask;
            result = result >> (q + i);
            bitsQK[i] = result;
        }

        //Get bits {p, p+1, ... , p+k-1} and saves them to array
        for (int i = 0; i <= (k - 1); i++)
        {
            mask = (long)1 << (p + i);
            result = N & mask;
            result = result >> (p + i);
            bitsPK[i] = result;
        }

        //Put bits {q, q+1, ... , q+k-1} to new position
        for (int j = 0; j <= (k - 1); j++)
        {
            if (bitsQK[j] == 1)
            {
                mask = 1 << (p + j);
                N = N | mask;
            }
            else
            {
                mask = ~(1 << (p + j));
                N = N & mask;
            }
        }

        //Put bits {p, p+1, ... , p+k-1} to new position
        for (int j = 0; j <= (k - 1); j++)
        {
            if (bitsPK[j] == 1)
            {
                mask = 1 << (q + j);
                N = N | mask;
            }
            else
            {
                mask = ~(1 << (q + j));
                N = N & mask;
            }
        }
        Console.WriteLine(N);
    }
}