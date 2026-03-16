// Write a program to determine loan eligibility based on age, income, and credit score using nested conditions.
using System;

class LoanEligibility
{
    static void Main()
    {
        int age, creditScore;
        double income;

        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter income: ");
        income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter credit score: ");
        creditScore = Convert.ToInt32(Console.ReadLine());

        if (age >= 21)
        {
            if (income >= 25000)
            {
                if (creditScore >= 650)
                {
                    Console.WriteLine("Loan Approved");
                }
                else
                {
                    Console.WriteLine("Loan Rejected due to low credit score");
                }
            }
            else
            {
                Console.WriteLine("Loan Rejected due to low income");
            }
        }
        else
        {
            Console.WriteLine("Loan Rejected due to age");
        }
    }
}