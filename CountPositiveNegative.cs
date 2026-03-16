// Count Positive and Negative Numbers using array
// Store 8 numbers in an array.
// Use a loop to traverse the array.
// Use if condition to count positive and negative numbers separately.
using System;

class CountPositiveNegative
{
    static void Main()
    {
        int[] numbers = new int[8];
        int positive = 0, negative = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Enter number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 8; i++)
        {
            if (numbers[i] > 0)
                positive++;
            else if (numbers[i] < 0)
                negative++;
        }

        Console.WriteLine("Positive numbers = " + positive);
        Console.WriteLine("Negative numbers = " + negative);
    }
}