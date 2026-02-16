//Write a program to input Principal Amount, Rate and Year and display Simple Interest.
using System;

class SimpleInterest
{
    static void Main()
    {
        double principal, rate, year, simpleInterest;

        Console.Write("Enter Principal Amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number of Years: ");
        year = Convert.ToDouble(Console.ReadLine());

        simpleInterest = (principal * rate * year) / 100;

        Console.WriteLine("Simple Interest is: " + simpleInterest);

        Console.ReadLine();
    }
}
