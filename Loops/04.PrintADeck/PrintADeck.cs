using System;

class PrintADeck
{
    static void Main()
    {
        string[] deckSymbol = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] colors = new string[] { "spades", "clubs", "hearts", "diamonds" };
        int enteredCardNumber;
        string enteredCard = Console.ReadLine();
        bool result = Int32.TryParse(enteredCard, out enteredCardNumber);
        if (result)
        {
            for (int i = 2; i <= enteredCardNumber; i++)
            {
                int countForComma = 1;
                foreach (var color in colors)
                {
                    Console.Write("{0} of {1}", i, color);
                    if (countForComma < 4)
                    {
                        Console.Write(", ");
                    }
                    countForComma++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            switch (enteredCard)
            {
                case "J":
                    int countToBreak = 0;
                    foreach (var symbol in deckSymbol)
                    {
                        int countForComma = 1;
                        foreach (var color in colors)
                        {
                            Console.Write("{0} of {1}", symbol, color);
                            if (countForComma < 4)
                            {
                                Console.Write(", ");
                            }
                            countForComma++;
                        }
                        Console.WriteLine();
                        countToBreak++;
                        if (countToBreak == 10) { break; }
                    }
                    break;

                case "Q":
                    countToBreak = 0;
                    foreach (var symbol in deckSymbol)
                    {
                        int countForComma = 1;
                        foreach (var color in colors)
                        {
                            Console.Write("{0} of {1}", symbol, color);
                            if (countForComma < 4)
                            {
                                Console.Write(", ");
                            }
                            countForComma++;
                        }
                        Console.WriteLine();
                        countToBreak++;
                        if (countToBreak == 11) { break; }
                    }
                    break;

                case "K":
                    countToBreak = 0;
                    foreach (var symbol in deckSymbol)
                    {
                        int countForComma = 1;
                        foreach (var color in colors)
                        {
                            Console.Write("{0} of {1}", symbol, color);
                            if (countForComma < 4)
                            {
                                Console.Write(", ");
                            }
                            countForComma++;
                        }
                        Console.WriteLine();
                        countToBreak++;
                        if (countToBreak == 12) { break; }
                    }
                    break;

                case "A":
                    countToBreak = 0;
                    foreach (var symbol in deckSymbol)
                    {
                        int countForComma = 1;
                        foreach (var color in colors)
                        {
                            Console.Write("{0} of {1}", symbol, color);
                            if (countForComma < 4)
                            {
                                Console.Write(", ");
                            }
                            countForComma++;
                        }
                        Console.WriteLine();
                        countToBreak++;
                        if (countToBreak == 13) { break; }
                    }
                    break;

                default: Console.WriteLine("Neshto e strosheno bre..."); break;
            }
        }
    }
}