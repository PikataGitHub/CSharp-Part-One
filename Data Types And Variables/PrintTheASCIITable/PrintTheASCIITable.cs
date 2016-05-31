using System;

    class PrintTheASCIITAble
    {
        static void Main()
        {
        for (byte i = 33; i <= 126; i++)
            {
            Console.Write((char)i);
            }
        }
    }