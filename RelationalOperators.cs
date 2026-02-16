//write a program to take 2 inputs from user and perform all relational operators and display correct output
using System;

class RelationalOperators
{
    static void Main()
    {
        int a, b;

        Console.WriteLine("Enter first number:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nRelational Operator Results:\n");

        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
        Console.WriteLine("a > b  : " + (a > b));
        Console.WriteLine("a < b  : " + (a < b));
        Console.WriteLine("a >= b : " + (a >= b));
        Console.WriteLine("a <= b : " + (a <= b));

        Console.ReadLine();
    }
}
