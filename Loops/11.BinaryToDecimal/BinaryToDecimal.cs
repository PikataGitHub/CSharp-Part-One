using System;

class BinaryToDecimal
{
    static void Main()
    {
        int counter = 0;
        string binaryNumber = Console.ReadLine();
        int[] numbers = new int[64];

        foreach (char c in binaryNumber)
        {
            numbers[counter] = int.Parse(c.ToString());
            counter++;
        }
        long decimalNumber = 0;
        for (int i = 0; i < counter; i++)
        {
            decimalNumber += numbers[(counter - i - 1)] * (long)Math.Pow(2, i);
        }
        Console.WriteLine(decimalNumber);
    }
}