using System;

class ThirdDigit
{
    static void Main()
    {
        long enteredNumber = long.Parse(Console.ReadLine());
        long digit=0;
        
        for (int i = 0; i < 3; i++)
        {
            digit = enteredNumber % 10;
            enteredNumber = enteredNumber / 10;
        }

        if (digit==7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false" + " " + digit);
        }
    }
}