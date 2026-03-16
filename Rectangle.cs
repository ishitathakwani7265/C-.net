// Create a class “Rectangle” that would contain length and width as an instance variable, define constructors [constructor overloading (default, parameterized)] to initialize variables of objects.Define methods to find area and to display variables’ value of objects which are created.
using System;

class Rectangle
{
    double length;
    double width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Area()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length = " + length);
        Console.WriteLine("Width = " + width);
        Console.WriteLine("Area = " + Area());
    }

    static void Main()
    {
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(10, 5);

        Console.WriteLine("Rectangle 1");
        r1.Display();

        Console.WriteLine("Rectangle 2");
        r2.Display();
    }
}