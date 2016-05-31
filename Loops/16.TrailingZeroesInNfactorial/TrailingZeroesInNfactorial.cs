using System;

class TrailingZeroesInNfactorial
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int counter = 0;
        do
        {
            counter = counter + N / 5;
            N = N / 5;
        } while (N > 1);
        Console.WriteLine(counter);
    }
}