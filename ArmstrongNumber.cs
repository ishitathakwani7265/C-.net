// Write a program to check weather a number is Armstrong or not.

using System;

class ArmstrongNumber
{
    static void Main()
    {
        int num, originalNum, remainder, sum = 0;

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        originalNum = num;

        while (num > 0)
        {
            remainder = num % 10;
            sum = sum + (remainder * remainder * remainder);
            num = num / 10;
        }

        if (originalNum == sum)
        {
            Console.WriteLine("The number is Armstrong");
        }
        else
        {
            Console.WriteLine("The number is not Armstrong");
        }
    }
}