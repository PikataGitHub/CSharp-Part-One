using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int j = 0; j < N; j++)
        {
            for (int i = (1 + j); i <= (N + j); i++)
            {
                Console.Write(i);
                if ((i >= (1+ j)) && (i < (N+ j)))
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}