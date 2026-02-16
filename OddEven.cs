//Write a program to input a number and print whether it is even or odd.
using System;

class OddEven
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("It is Even");
        }
        else
        {
            Console.WriteLine("It is Odd");
        }

        Console.ReadLine();
    }
}
