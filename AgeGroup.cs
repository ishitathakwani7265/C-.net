//Write a program to input age of a person and display message of person and display message as follows - if age<12 print you are kid,if age between 12 to 17 print you are a teenager and if age is between 18 to 60 print you are adult and if age>60 print you ar senior citizen.
using System;

class AgeGroup
{
    static void Main()
    {
        int age;

        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("You are kid");
        }
        else if (age >= 12 && age <= 17)
        {
            Console.WriteLine("You are teenager");
        }
        else if (age >= 18 && age <= 60)
        {
            Console.WriteLine("You are adult");
        }
        else
        {
            Console.WriteLine("You are senior citizen");
        }

        Console.ReadLine();
    }
}
