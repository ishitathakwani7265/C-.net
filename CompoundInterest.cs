//write a program to input principal amount, rate and year and display compound interest
using System;

class Program
{
    static void Main()
    {
        double p, r, t, amount, ci;

        Console.Write("Enter Principal Amount: ");
        p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Years: ");
        t = Convert.ToDouble(Console.ReadLine());

        amount = p * Math.Pow(1 + r / 100, t);
        ci = amount - p;

        Console.WriteLine("Compound Interest = " + ci);

        Console.ReadLine();
    }
}