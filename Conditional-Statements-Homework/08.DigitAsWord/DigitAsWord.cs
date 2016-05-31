using System;

class DigitAsWord
{
    static void Main()
    {
        string input = Console.ReadLine();
        int digit;
        bool result = Int32.TryParse(input, out digit);

        if (result && (digit == 0 || digit == 1 || digit == 2 || digit == 3 || digit == 4 || digit == 5 || digit == 6 || digit == 7 || digit == 8 || digit == 9))
        {
            switch (digit)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("Ima neshto neredno tuka"); break;
            }            
        }
        else
        {
            Console.WriteLine("not a digit");
        }
    }
}