using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
        int? firstNumber = null;
        double? secondNumber = null;

        firstNumber = firstNumber + 10;
        secondNumber = secondNumber + 12.6;

        //Console.WriteLine(firstNumber);
        //Console.WriteLine(secondNumber);

        firstNumber = firstNumber + null;
        secondNumber = secondNumber + null;
        
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        }
    }