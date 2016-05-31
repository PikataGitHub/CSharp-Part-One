using System;

class OddOrEven
    {
        static void Main()
        {
            int intNumber = Int32.Parse(Console.ReadLine());
            if (intNumber%2==0)
                {
                    Console.WriteLine("even"+   " " +   intNumber);
                }
            else
                {
                    Console.WriteLine("odd" + " " + intNumber);
                }

        }
    }