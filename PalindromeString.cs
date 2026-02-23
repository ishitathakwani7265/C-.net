// Write a program to check weather a string is palindrome or not.

using System;

class PalindromeString
{
    static void Main()
    {
        string str, reverse = "";

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse = reverse + str[i];
        }

        if (str == reverse)
        {
            Console.WriteLine("The string is Palindrome");
        }
        else
        {
            Console.WriteLine("The string is not Palindrome");
        }
    }
}