// Definition : Write a program to implement an interface called Pass(int mark) that returns a boolean value. Write another interface called Division(int average) that returns a String. Create a class called Result which implements both the interfaces. The Pass method should return true if the mark is greater than or equal to 50, otherwise it should return false. The Division method should return division based on average.

using System;

interface IPass
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class Result : IPass, IDivision
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Result r = new Result();

        Console.Write("Enter marks: ");
        int mark = int.Parse(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = int.Parse(Console.ReadLine());

        Console.WriteLine("Pass: " + r.Pass(mark));
        Console.WriteLine("Division: " + r.Division(avg));
    }
}