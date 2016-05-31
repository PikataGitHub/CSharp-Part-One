using System;

class PoinCircleRectangle
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        double distanceBetween = Math.Sqrt((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1));


        if (distanceBetween <= 1.5)
        {
            Console.Write("inside circle" + " ");
            if ((pointX >= -1 && pointX <= 5) && (pointY >= -1 && pointY <= 1))
            {
                Console.Write("inside rectangle");
            }
            else
            {
                Console.Write("outside rectangle");
            }
        }
        else
        {
            Console.Write("outside circle" + " ");
            if ((pointX >= -1 && pointX <= 5) && (pointY >= -1 && pointY <= 1))
            {
                Console.Write("inside rectangle");
            }
            else
            {
                Console.Write("outside rectangle");
            }
        }

    }
}