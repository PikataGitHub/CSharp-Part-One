using System;

class DecimalToBinary
{
    static void Main()
    {
        long enteredN = long.Parse(Console.ReadLine());
        long[] symbols = new long[64];
        int counter = 0;
        if (enteredN==0)
        {
            Console.WriteLine(enteredN); return;
        }
        if (enteredN==1)
        {
            Console.WriteLine(enteredN); return;
        }
        do
        {
            symbols[counter] = enteredN % (long)2;
            //Console.WriteLine(symbols[counter]);
            counter++;
            enteredN = enteredN / 2;
            if (enteredN==1)
            {
                symbols[counter] = 1;
            }
        } while ((enteredN / 2) > 0);

        for (int i = (counter); i >= 0; i--)
        {
            Console.Write(symbols[i]);
        }
    }
}