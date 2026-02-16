//Write a Program to check whether a number inputted by user is prime or not

using System;

class PrimeorNot
{
    static void Main(string[] args)
    {
        int number;
        bool isPrime = true;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + " is a Prime number");
        }
        else
        {
            Console.WriteLine(number + " is not a Prime number");
        }

        Console.ReadLine();
    }
}
