using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int E = int.Parse(Console.ReadLine());

        int sum = A + B + C + D + E;
        Console.WriteLine(sum);
    }
}