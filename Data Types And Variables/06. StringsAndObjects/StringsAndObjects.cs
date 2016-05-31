using System;

    class StringsAndObjects
    {
        static void Main()
        {

        string firsVar = "Hello ";
        string secondVar = " World";

        object thirdVar = firsVar + secondVar;

        Console.WriteLine(thirdVar);

        string fourthVar = (string)thirdVar;

        Console.WriteLine(fourthVar);

        }
    }