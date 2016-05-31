using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Int32 numberN = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            Console.Write(i);
            if ((i >= 1) && (i < numberN))
            {
                Console.Write(" ");
            }
        }
    }
}