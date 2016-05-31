using System;

class FibonacciNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long first = 0;
        long second = 1;
        long sum = 0;

        if (N == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.Write("{0}, {1}", first, second);
            for (int i = 2; i < N; i++)
            {
                sum = first + second;
                Console.Write(", {0}", sum);

                first = second;
                second = sum;
            }
        }
    }
}