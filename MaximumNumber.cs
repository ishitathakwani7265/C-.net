// Write a program to display maximum number from inputted 5 numbers from user.
using System;

class MaximumNumber
{
    static void Main()
    {
        int n1, n2, n3, n4, n5, max;

        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        n5 = Convert.ToInt32(Console.ReadLine());

        max = n1;

        if (n2 > max)
            max = n2;

        if (n3 > max)
            max = n3;

        if (n4 > max)
            max = n4;

        if (n5 > max)
            max = n5;

        Console.WriteLine("Maximum number = " + max);
    }
}