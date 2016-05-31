using System;

class Program
{
     static void Main(string[] args)
     {
        DateTime dneska = DateTime.Today;

        DateTime rojdenDen = DateTime.Parse(Console.ReadLine());

        int age = dneska.Year - rojdenDen.Year;

        if (dneska.Month < rojdenDen.Month || (dneska.Month == rojdenDen.Month && dneska.Day < rojdenDen.Day))
                age--;

        Console.WriteLine(age);
        Console.WriteLine(age+10);
    }
}