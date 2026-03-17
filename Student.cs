// Create a class “Student” that contains rollNo, name, and marks as instance variables. Define constructors (default and parameterized) to initialize these variables. Create methods to calculate grade based on marks and display student details.

using System;

class Student
{
    int rollNo;
    string name;
    int marks;

    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    public Student(int r, string n, int m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public string CalculateGrade()
    {
        if (marks >= 80)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 40)
            return "C";
        else
            return "Fail";
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Display();

        Student s2 = new Student(1, "Rahul", 75);
        s2.Display();
    }
}