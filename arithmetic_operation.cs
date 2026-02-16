//write a program that take 2 inputs number from user and perform all arithmetic operations
using System;

class arithmetic_operation
{
    static void Main()
    {
        int num1, num2;
        int add, sub, mul;
        float div, mod;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        add = num1 + num2;
        sub = num1 - num2;
        mul = num1 * num2;
        div = (float)num1 / num2;
        mod = num1 % num2;

        Console.WriteLine("Addition = " + add);
        Console.WriteLine("Subtraction = " + sub);
        Console.WriteLine("Multiplication = " + mul);
        Console.WriteLine("Division = " + div);
        Console.WriteLine("Modulus = " + mod);

        Console.ReadLine();
    }
}
