using System;

class DevideBy7And5
{
    static void Main()
    {

        int numberToBeChecked = int.Parse(Console.ReadLine());
        string savedVariable;

        if (numberToBeChecked % 7 == 0 && numberToBeChecked % 5 == 0)
        {
            savedVariable = "true";
        }
        else
        {
            savedVariable = "false";
        }

        Console.WriteLine(savedVariable + " " + numberToBeChecked);
    }
}