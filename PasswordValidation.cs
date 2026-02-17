/*Create Password Validation System

A program that keeps asking for a password until it meets conditions like length, digit, uppercase letter, etc.

Loop until valid password
Conditions for validation rules
*/
using System;

class PasswordValidation
{
    static void Main()
    {
        string password;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            bool hasUppercase = false;
            bool hasDigit = false;

            if (password.Length >= 8)
            {
                foreach (char ch in password)
                {
                    if (char.IsUpper(ch))
                        hasUppercase = true;

                    if (char.IsDigit(ch))
                        hasDigit = true;
                }

                if (hasUppercase && hasDigit)
                {
                    isValid = true;
                }
            }

            if (!isValid)
            {
                Console.WriteLine("Invalid password!");
                Console.WriteLine("Password must:");
                Console.WriteLine("- Be at least 8 characters long");
                Console.WriteLine("- Contain at least one uppercase letter");
                Console.WriteLine("- Contain at least one digit");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Password accepted!");
        Console.ReadLine();
    }
}
