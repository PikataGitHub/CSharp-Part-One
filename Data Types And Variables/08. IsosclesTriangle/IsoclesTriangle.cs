using System;
using System.Text;

class IsoclesTriangle
{
    static void Main()
        {

        Console.OutputEncoding = Encoding.UTF8;

        char copyRight = '\u00A9';
        Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", copyRight);

        Console.WriteLine("©");

        int n = 7;

        for (int i = 1; i <= n; i += 2)
        {
            for (int k = (n - i) / 2; k >= 0; k--)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }

    }
}