//Write a Program to find Fibonacci Series up to a number inputted by user

using System;

class FibonacciSeries
{
    static void Main(string[] args)
    {
        int number;
        int first = 0;
        int second = 1;
        int next;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= number; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }

        Console.ReadLine();
    }
}
