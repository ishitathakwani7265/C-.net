//write a program to input radius of a circle, and print area of that circle
using System;

class RadiusofCircle
{
    static void Main()
    {
        double r, area;

        Console.Write("Enter radius: ");
        r = Convert.ToDouble(Console.ReadLine());

        area = 3.14 * r * r;

        Console.WriteLine("Area of circle = " + area);

        Console.ReadLine();
    }
}
