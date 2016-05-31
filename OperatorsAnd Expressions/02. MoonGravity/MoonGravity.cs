using System;

class MoonGravity
    {
        static void Main()
        {
        float earthWeight = float.Parse(Console.ReadLine());
        float moonWeight = 0.17f * earthWeight;

        Console.WriteLine(moonWeight.ToString("F3"));
        }
    }