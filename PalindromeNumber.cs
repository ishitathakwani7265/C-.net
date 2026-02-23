// Write a program to check weather a number is palindrome or not.

using System;

class PalindromeNumber
{
    static void Main()
    {
        int num, originalNum, remainder, reverse = 0;

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        originalNum = num;

        while (num > 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10;
        }

        if (originalNum == reverse)
        {
            Console.WriteLine("The number is Palindrome");
        }
        else
        {
            Console.WriteLine("The number is not Palindrome");
        }
    }
}