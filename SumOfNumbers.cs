//Write a program to calculate sum of number inputted by the user.
using System;

class SumOfNumbers
{
    static void Main()
    {
        int n, num, sum = 0;

        Console.Write("How many numbers do you want to enter? ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number " + i + ": ");
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;
        }

        Console.WriteLine("The sum of the numbers is: " + sum);

        Console.ReadLine();
    }
}
