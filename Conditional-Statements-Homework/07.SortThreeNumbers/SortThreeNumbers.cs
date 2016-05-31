using System;

class SortThreeNumbers
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        if (A >= B)
        {
            if (B >= C)
            {
                Console.WriteLine("{0} {1} {2}", A, B, C);
            }
            else
            {
                if (A >= C)
                {
                    Console.WriteLine("{0} {1} {2}", A, C, B);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", C, A, B);
                }
            }
        }
        else
        {
            if (A >= C)
            {
                Console.WriteLine("{0} {1} {2}", B, A, C);
            }
            else
            {
                if (B >= C)
                {
                    Console.WriteLine("{0} {1} {2}", B, C, A);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", C, B, A);
                }
            }
        }
    }
}