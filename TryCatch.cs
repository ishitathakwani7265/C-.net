/*
Write a program to demonstrate the use of try and catch in C#.
*/

using System;

class ExceptionDemo
{
    static void Main(string[] args)
    {
        try
        {
            int a, b, c;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a / b;

            Console.WriteLine("Result = " + c);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
    }
}