using System;

class PlayCard
{
    static void Main(string[] args)
    {
        string[] playCards = new string[]
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
        };
        string enteredString = Console.ReadLine();
        foreach (string c in playCards)
        {
            if (string.Equals(c, enteredString, StringComparison.Ordinal))
            {
                Console.WriteLine("yes {0}",enteredString);
                return;
            }            
        }
        Console.WriteLine("no {0}", enteredString);
    }
}