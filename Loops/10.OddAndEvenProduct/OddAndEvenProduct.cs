using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        ulong evenProduct = 1;
        ulong oddProduct = 1;
        
        for (int i = 0; i < N; i+=2)
        {
            oddProduct *= ulong.Parse(numbers[i]);
        }
        for (int j = 1; j < N; j+=2)
        {
            evenProduct *= ulong.Parse(numbers[j]);
        }
        if (evenProduct==oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}