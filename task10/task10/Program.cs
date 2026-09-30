using System;

public class Program
{
    static double CircleArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }

    public static void Main()
    {
        double radius;

        do
        {
            Console.Write("Enter circle radius or 0 to exit: ");
            radius = Convert.ToDouble(Console.ReadLine());

            if (radius != 0)
            {
                double area = CircleArea(radius);
                Console.WriteLine("Circle area: " + area);
                Console.WriteLine();
            }

        } while (radius != 0);

        Console.WriteLine("Program ended.");
    }
}