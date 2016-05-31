using System;

class FourDigits
{
    static void Main()
    {
        int fourDigitNumber = int.Parse(Console.ReadLine());

        int[] digits = new int[4];
        int sumOfDigits = 0;

        for (int i = 0; i < 4; i++)
        {
            digits[i] = fourDigitNumber % 10;
            fourDigitNumber = fourDigitNumber / 10;
            sumOfDigits = sumOfDigits + digits[i];
        }

        Console.WriteLine(sumOfDigits);
        for (int j = 0; j < 4; j++)
        {
            Console.Write(digits[j]);
        }
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(digits[0]) + Convert.ToString(digits[3]) + Convert.ToString(digits[2]) + Convert.ToString(digits[1]));
        Console.WriteLine(digits[0]+digits[1]*100+digits[2]*10+digits[3]*1000);
    }
}