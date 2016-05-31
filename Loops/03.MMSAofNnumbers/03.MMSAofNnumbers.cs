using System;

class MMSAofNnumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        double[] numberArray = new double[numberN];
        double minNumbers = 0;
        double maxNumbers = 0;
        double sumNumbers = 0;
        double averageNumbers = 0;

        for (int i = 0; i < numberN; i++)
        {
            numberArray[i] = double.Parse(Console.ReadLine());
            sumNumbers = sumNumbers + numberArray[i];            
        }
        averageNumbers = sumNumbers / numberN;
        minNumbers = numberArray[0];
        maxNumbers = numberArray[0];

        for (int i = 0; i < numberN; i++)
        {
            if (numberArray[i] < minNumbers)
            {
                minNumbers = numberArray[i];
            }
            if (numberArray[i] > maxNumbers)
            {
                maxNumbers = numberArray[i];
            }
        }        
        Console.WriteLine("min={0:F2}", minNumbers);
        Console.WriteLine("max={0:F2}", maxNumbers);
        Console.WriteLine("sum={0:F2}", sumNumbers);
        Console.WriteLine("avg={0:F2}", averageNumbers);
    }
}