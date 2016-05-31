using System;

class PrinSequence
{
    static void Main()
    {
        for (int counter = 2; counter < 1002; counter++)
        {
            if (counter % 2 == 0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("-" + counter);
            }
        }
    }
}