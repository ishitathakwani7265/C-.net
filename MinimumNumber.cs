// Write a program to display minimum number from inputted 5 numbers from user.
using System;

class MinimumNumber
{
    static void Main()
    {
        int n1, n2, n3, n4, n5, min;

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

        min = n1;

        if (n2 < min)
            min = n2;

        if (n3 < min)
            min = n3;

        if (n4 < min)
            min = n4;

        if (n5 < min)
            min = n5;

        Console.WriteLine("Minimum number = " + min);
    }
}