// Create a class “Employee” that contains employeeId, name, and salary as instance variables. Define constructors (default and parameterized) to initialize the values. Create methods to calculate annual salary and display employee information.

using System;

class Employee
{
    int employeeId;
    string name;
    double salary;

    public Employee()
    {
        employeeId = 0;
        name = "";
        salary = 0;
    }

    public Employee(int id, string n, double s)
    {
        employeeId = id;
        name = n;
        salary = s;
    }

    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee(101, "Khushi", 50000);

        e1.Display();
        Console.WriteLine();
        e2.Display();
    }
}