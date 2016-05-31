using System;

class HexToDecimal
{
    static void Main()
    {
        int counter = 0;
        string hexNumber = Console.ReadLine();
        int[] numbers = new int[64];

        foreach (char c in hexNumber)
        {
            switch (c)
            {
                case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': numbers[counter] = int.Parse(c.ToString()); break;
                case 'A': numbers[counter] = 10; break;
                case 'B': numbers[counter] = 11; break;
                case 'C': numbers[counter] = 12; break;
                case 'D': numbers[counter] = 13; break;
                case 'E': numbers[counter] = 14; break;
                case 'F': numbers[counter] = 15; break;
                default: Console.WriteLine("neshto e strosheno"); break;
            }
            counter++;
        }
        long decimalNumber = 0;
        for (int i = 0; i < counter; i++)
        {
            decimalNumber = decimalNumber + numbers[(counter - i - 1)] * (long)Math.Pow(16, i);
        }
        Console.WriteLine(decimalNumber);
    }
}