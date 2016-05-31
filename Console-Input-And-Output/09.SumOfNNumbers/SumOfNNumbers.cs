using System;

class SumOfNNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double number = 0;
        double sum = 0;

        for (int i = 1; i <= N; i++)
        {
            number = double.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine(sum);
    }
}