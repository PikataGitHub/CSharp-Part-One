using System;

class GreatestCommonDevisor
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int A = int.Parse(numbers[0]);
        int B = int.Parse(numbers[1]);

        while (Math.Abs(A - B) > 0)
        {
            if (A < B)
            {
                B = B - A;
            }
            else
            {
                A = A - B;
            }
        }
        Console.WriteLine(Math.Min(A, B));

    }
}