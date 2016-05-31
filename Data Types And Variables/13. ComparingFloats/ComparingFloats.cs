using System;

   class ComparingFloats
    {
        static void Main()
        {
        const double eps = 0.000001;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double differanceE = Math.Abs(firstNumber - secondNumber);

        if (differanceE<eps)
            {
                Console.WriteLine("true");
            }
        else
            {
                Console.WriteLine("false");
            }
        }
    }