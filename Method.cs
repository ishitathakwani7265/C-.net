// Definition : Create an interface named Pass(int mark) → returns a boolean value. Create another interface named that contains a method: Division(int average) → returns a String. Now, create a class named that implements both the and interfaces. Functional Requirements:The Pass(int mark) method should: Return if the marks are Otherwise, return The Division(int average) method should: Return if average is Return if average is Return if average is

using System;

interface IResult
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class StudentResult : IResult, IDivision
{
    public bool Pass(int mark)
    {
        if (mark >= 40)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Division(int average)
    {
        if (average >= 60)
        {
            return "First Division";
        }
        else if (average >= 50)
        {
            return "Second Division";
        }
        else
        {
            return "Third Division";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentResult s = new StudentResult();

        Console.WriteLine("Enter marks:");
        int mark = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter average:");
        int avg = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pass: " + s.Pass(mark));
        Console.WriteLine("Division: " + s.Division(avg));
    }
}