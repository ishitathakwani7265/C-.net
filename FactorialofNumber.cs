//Write a Program to find factorial of given number

using System;

class FactorialofNumber
{
    static void Main(string[] args)
    {
        int number;
        int factorial = 1;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("Factorial of " + number + " is: " + factorial);
        Console.ReadLine();
    }
}
