using System;

    class ExchangeVariableValues
    {
        static void Main()
        {

        int number5 = 5;
        int number10 = 10;
        int exchangeVar;

        Console.WriteLine(number5);
        Console.WriteLine(number10);

        exchangeVar = number5;
        number5 = number10;
        number10 = exchangeVar;

        Console.WriteLine("Новата стойност на number5 e: {0}", number5);
        Console.WriteLine("Новата стойност на number10 е: {0}", number10);

        }
    }