// Write a program to verify PIN first, then allow withdrawal only if balance is sufficient.
using System;

class ATMWithdrawal
{
    static void Main()
    {
        int pin, enteredPin;
        double balance, amount;

        Console.Write("Set your PIN: ");
        pin = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your balance: ");
        balance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter PIN: ");
        enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == pin)
        {
            Console.Write("Enter withdrawal amount: ");
            amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining Balance = " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        else
        {
            Console.WriteLine("Incorrect PIN");
        }
    }
}