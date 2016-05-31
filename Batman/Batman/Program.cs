using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class batman
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        char C = char.Parse(Console.ReadLine());
        int topPart = N / 2;
        int middlePart = N / 2 - 1;
        int bottomPart = N / 2;
        int arrayX = topPart + middlePart + bottomPart;
        int arrayY = 3 * N;

        char[,] symbols = new char[arrayX, arrayY];


        for (int i = 0; i < arrayX; i++)
        {
            for (int j = 0; j < arrayY; j++)
            {
                symbols[i, j] = ' ';
            }
        }



        for (int i = 0; i < topPart; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i <= j)
                {
                    symbols[i, j] = C;
                }
            }
        }


        for (int i = 0; i < topPart; i++)
        {
            for (int j = (arrayY - 1 - i); j >= (2 * N); j--)
            {
                symbols[i, j] = C;
            }
        }

        for (int i = topPart; i < (topPart + middlePart); i++)
        {
            for (int j = (topPart); j < (arrayY - topPart); j++)
            {
                symbols[i, j] = C;
            }
        }

        //Tuk da vidim kakvo e ?!?!?!??

        int counter = 0;

        for (int i = (topPart + middlePart); i < arrayX; i++)
        {
            for (int j = (N + 1 + counter); j < ((2 * N) - 1 - counter); j++)
            {
                symbols[i, j] = C;
            }
            counter++;
        }


        symbols[(topPart - 1), ((3 * N) / 2 - 1)] = C;
        symbols[(topPart - 1), ((3 * N) / 2 + 1)] = C;


        //Print the matrix
        for (int i = 0; i < arrayX; i++)
        {
            for (int j = 0; j < arrayY; j++)
            {
                Console.Write(symbols[i, j]);
            }
            Console.WriteLine();
        }


    }
}