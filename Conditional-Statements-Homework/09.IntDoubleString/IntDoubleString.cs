using System;

class IntDoubleString
{
    static void Main()
    {
        string inputFirsLine = Console.ReadLine();

        switch (inputFirsLine)
        {
            case "integer":
                int numberInt = Int32.Parse(Console.ReadLine());
                Console.WriteLine(numberInt+1);
                break;
            case "real":
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", (number + 1));
                break;
            case "text":
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
            default: Console.WriteLine("Neshto se schupi"); break;
        }
    }
}