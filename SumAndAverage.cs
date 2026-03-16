// Calculate Sum and Average
// Store marks of 5 students in an array.
// Use a loop to calculate total marks.
// Calculate and display the average.
using System;

class SumAndAverage
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;
        double average;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter marks: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            sum = sum + marks[i];
        }

        average = sum / 5.0;

        Console.WriteLine("Total Marks = " + sum);
        Console.WriteLine("Average = " + average);
    }
}