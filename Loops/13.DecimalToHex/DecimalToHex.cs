using System;

class DecimalToHex
{
    static void Main()
    {
        long enteredNum = long.Parse(Console.ReadLine());
        int counter = 0;
        string[] symbols = new string[64];
        long leftOver = 0;
        do
        {
            leftOver = enteredNum % (long)16;
            switch (leftOver)
            {
                case 0: case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: symbols[counter] = leftOver.ToString(); break;
                case 10: symbols[counter] = "A"; break;
                case 11: symbols[counter] = "B"; break;
                case 12: symbols[counter] = "C"; break;
                case 13: symbols[counter] = "D"; break;
                case 14: symbols[counter] = "E"; break;
                case 15: symbols[counter] = "F"; break;
                default: Console.WriteLine("neshto e strosheno"); break;
            }
            enteredNum = enteredNum / (long)16;
            counter++;
        } while (enteredNum > 0);

        for (int i = (counter - 1); i >= 0; i--)
        {
            Console.Write(symbols[i]);
        }
    }
}