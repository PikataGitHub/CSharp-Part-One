using System;

class PrimeCheck
{
    static void Main()
    {
        int enteredNumber = int.Parse(Console.ReadLine());

        if (enteredNumber <= 1)
        {
            Console.WriteLine("false");
        }
        else if (enteredNumber==2 || enteredNumber==3)
        {
            Console.WriteLine("true");
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(enteredNumber); i++)
            {
                if (enteredNumber%i==0)
                {
                    Console.WriteLine("false");
                    return;
                }                
            }
            Console.WriteLine("true");
        }
    }
}