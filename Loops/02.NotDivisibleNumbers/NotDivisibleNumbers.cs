using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Int32 numberN = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            if ((i % 3) == 0)
            {
                i++;
            }
            if ((i % 7) == 0)
            {
                i++;
            }
            if ((i % 3) == 0)
            {
                i++;
            }
            if ((i >= 1) && (i <= numberN))
            {
                Console.Write(i);
                if ((i >= 1) && (i < numberN))
                {
                    Console.Write(" ");
                }            
            }
        }
    }
}